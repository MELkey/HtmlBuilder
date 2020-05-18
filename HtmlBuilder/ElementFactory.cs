using HtmlBuilder.Serializer;
using HtmlBuilder.Tags;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HtmlBuilder
{
    public class ElementFactory : IElementFactory
    {
        public IElement<TAttributesSet, IElement> Create<TAttributesSet>(
            Expression<Func<ITagSet<IElement>, IElement<TAttributesSet, IElement>>> tagSelector)
            where TAttributesSet : GlobalElement, new()
        {
            var serializerFactory = new HtmlSerializerFactory();
            Element<TAttributesSet, IElement> element = null;
            element = new Element<TAttributesSet, IElement>(null, element, null, serializerFactory);

            return element;
        }

        public IElement<TAttributesSet, IElement> Create<TAttributesSet>(
            Expression<Func<ITagSet<IElement>, IElement<TAttributesSet, IElement>>> tagSelector,
            IHtmlSerializerFactory serializerFactory)
            where TAttributesSet : GlobalElement, new()
        {
            Element<TAttributesSet, IElement> element = null;
            element = new Element<TAttributesSet, IElement>(null, element, null, serializerFactory);

            return element;
        }

    }
}
