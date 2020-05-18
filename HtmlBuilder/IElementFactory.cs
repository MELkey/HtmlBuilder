using HtmlBuilder.Tags;
using System;
using System.Linq.Expressions;

namespace HtmlBuilder
{
    public interface IElementFactory
    {
        IElement<TAttributesSet, IElement> Create<TAttributesSet>(Expression<Func<ITagSet<IElement>, IElement<TAttributesSet, IElement>>> tagSelector) where TAttributesSet : IGlobalElement, new();
        IElement<TAttributesSet, IElement> Create<TAttributesSet>(Expression<Func<ITagSet<IElement>, IElement<TAttributesSet, IElement>>> tagSelector, IHtmlSerializerFactory serializerFactory) where TAttributesSet : IGlobalElement, new();
    }
}