using HtmlBuilder.Attributes;
using HtmlBuilder.Tags;
using System;
using System.Linq.Expressions;

namespace HtmlBuilder
{
    internal sealed class Element<TTag, TParent> : ElementBase, IElement<TTag, TParent> 
        where TTag : IGlobalElement, new()
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

        public IAttributeConfigurator<TAttribute, IElement<TTag, TParent>> AddAttribute<TAttribute>(
            Expression<Func<TTag, TAttribute>> attributeSelector)
            where TAttribute : IAttribute, new()
        {
            
            var attribute = new TAttribute();
            attributes.Add(attribute);
            var configurator = new AttributeConfigurator<TAttribute, IElement<TTag, TParent>>(attribute, this);
            return configurator;
        }

        public IElement<TTag, TParent> AddCustomAttribute(string name, string value)
        {
            var attribute = new CustomAttribute(name);
            attribute.SetValue(value);
            attributes.Add(attribute);
            return this;
        }

        public IElement<TChildAttributesSet, IElement<TTag, TParent>> AddChild<TChildAttributesSet>(
            Expression<Func<ITagSet<TParent>, IElement<TChildAttributesSet, TParent>>> tagSelector)
            where TChildAttributesSet : IGlobalElement, new()
        {
            var child = new Element<TChildAttributesSet, IElement<TTag, TParent>>(Document, Root, this, serializerFactory);
            childs.Add(child);
            return child;
        }

        public IElement<TChildAttributesSet, IElement<TTag, TParent>> AddChild<TChildAttributesSet>(
            Expression<Func<ITagSet<TParent>, IElement<TChildAttributesSet, TParent>>> tagSelector,
            out IElement<TChildAttributesSet, IElement<TTag, TParent>> child)
            where TChildAttributesSet : IGlobalElement, new()
        {
            var result = new Element<TChildAttributesSet, IElement<TTag, TParent>>(Document, Root, this, serializerFactory);
            child = result;
            childs.Add(child);
            return child;
        }

        public IElement<CustomTag, IElement<TTag, TParent>> AddCustomChild(string name)
        {
            var tag = new CustomTag(name);
            var child = new Element<CustomTag, IElement<TTag, TParent>>(Document, Root, this, tag, serializerFactory);
            childs.Add(child);
            return child;
        }

        public IElement<TChildAttributesSet, IElement<TTag, TParent>> AddChild<TChildAttributesSet, TParrentOld>(
            IElement<TChildAttributesSet, TParrentOld> element)
            where TChildAttributesSet : IGlobalElement, new()
            where TParrentOld : IElement
        {
            var child = new Element<TChildAttributesSet, IElement<TTag, TParent>>(Document, Root, this, serializerFactory);
            Copy(element, child);
            childs.Add(child);
            return child;
        }

        public IElement<TTag, TParent> AddContent(string content)
        {
            this.content.Add(content);
            return this;
        }

        private void Copy<TTagNew, TParrentNew, TTagOld, TParrentOld>(
            IElement<TTagOld, TParrentOld> oldElement,
            Element<TTagNew, TParrentNew> newElement)
            where TParrentNew : IElement
            where TParrentOld : IElement
            where TTagNew : IGlobalElement, new()
            where TTagOld : IGlobalElement, new()
        {
            newElement.childs.AddRange(oldElement.Childs);
            newElement.attributes.AddRange(oldElement.Attributes);
            newElement.content.AddRange(oldElement.Content);
        }
    }
}
