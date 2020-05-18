using System;

namespace HtmlBuilder
{
    public interface IAttributeConfigurator<TAttribute, TElement>
        where TAttribute : IAttribute
        where TElement : IElement
    {
        TElement Setup(Action<TAttribute> action);
    }
}