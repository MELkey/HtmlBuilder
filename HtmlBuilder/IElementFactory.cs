using HtmlBuilder.Tags;
using System;
using System.Linq.Expressions;

namespace HtmlBuilder
{
    public interface IElementFactory
    {
        Element<TAttributesSet, IElement> Create<TAttributesSet>(Expression<Func<ITagSet<IElement>, Element<TAttributesSet, IElement>>> tagSelector) where TAttributesSet : GlobalElement, new();
        Element<TAttributesSet, IElement> Create<TAttributesSet>(Expression<Func<ITagSet<IElement>, Element<TAttributesSet, IElement>>> tagSelector, IHtmlSerializerFactory serializerFactory) where TAttributesSet : GlobalElement, new();
    }
}