using HtmlBuilder.Attributes;
using HtmlBuilder.Tags;
using System;
using System.Linq.Expressions;

namespace HtmlBuilder
{
    public sealed class Element<TTag, TParent> : ElementBase
        where TTag : GlobalElement, new()
        where TParent : IElement
    {
        private readonly TTag attributeSet;
        public new TParent Parent { get; }

        internal Element(Document document, IElement root, TParent parrent, IHtmlSerializerFactory serializerFactory) :
            base(document, root, parrent, serializerFactory)
        {
            attributeSet = new TTag();
            name = attributeSet.TagName;
            Parent = (TParent)base.Parent;
        }

        private Element(Document document, IElement root, TParent parrent, TTag attributeSet, IHtmlSerializerFactory serializerFactory) :
            base(document, root, parrent, serializerFactory)
        {
            name = attributeSet.TagName;
            Parent = (TParent)base.Parent;
        }

        public Element<TTag, TParent> AddAttribute<TAttribute>(
            Expression<Func<TTag, TAttribute>> attributeSelector,
            Expression<Action<TAttribute>> valueAction)
            where TAttribute : IAttribute, new()
        {
            var attribute = new TAttribute();
            valueAction.Compile().Invoke(attribute);

            attributes.Add(attribute);

            return this;
        }

        public Element<TTag, TParent> AddCustomAttribute(string name, string value)
        {
            var attribute = new CustomAttribute(name);
            attribute.SetValue(value);
            attributes.Add(attribute);
            return this;
        }

        public Element<TChildAttributesSet, Element<TTag, TParent>> AddChild<TChildAttributesSet>(
            Expression<Func<ITagSet<TParent>, Element<TChildAttributesSet, TParent>>> tagSelector)
            where TChildAttributesSet : GlobalElement, new()
        {
            var child = new Element<TChildAttributesSet, Element<TTag, TParent>>(Document, Root, this, serializerFactory);
            childs.Add(child);
            return child;
        }

        public Element<TChildAttributesSet, Element<TTag, TParent>> AddChild<TChildAttributesSet>(
            Expression<Func<ITagSet<TParent>, Element<TChildAttributesSet, TParent>>> tagSelector,
            out Element<TChildAttributesSet, Element<TTag, TParent>> child)
            where TChildAttributesSet : GlobalElement, new()
        {
            var result = new Element<TChildAttributesSet, Element<TTag, TParent>>(Document, Root, this, serializerFactory);
            child = result;
            childs.Add(child);
            return child;
        }

        public Element<CustomTag, Element<TTag, TParent>> AddCustomChild(string name)
        {
            var tag = new CustomTag(name);
            var child = new Element<CustomTag, Element<TTag, TParent>>(Document, Root, this, tag, serializerFactory);
            childs.Add(child);
            return child;
        }

        public Element<TChildAttributesSet, Element<TTag, TParent>> AddChild<TChildAttributesSet, TParrentOld>(
            Element<TChildAttributesSet, TParrentOld> element)
            where TChildAttributesSet : GlobalElement, new()
            where TParrentOld : IElement
        {
            var child = new Element<TChildAttributesSet, Element<TTag, TParent>>(Document, Root, this, serializerFactory);
            Copy(element, child);
            childs.Add(child);
            return child;
        }

        public Element<TTag, TParent> AddContent(string content)
        {
            this.content.Add(content);
            return this;
        }

        private void Copy<TTagNew, TParrentNew, TTagOld, TParrentOld>(
            Element<TTagOld, TParrentOld> oldElement,
            Element<TTagNew, TParrentNew> newElement)
            where TParrentNew : IElement
            where TParrentOld : IElement
            where TTagNew : GlobalElement, new()
            where TTagOld : GlobalElement, new()
        {
            newElement.childs.AddRange(oldElement.childs);
            newElement.attributes.AddRange(oldElement.attributes);
            newElement.content.AddRange(oldElement.content);
        }
    }
}
