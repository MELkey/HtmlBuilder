using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
    internal class AttributeConfigurator<TAttribute, TElement> : IAttributeConfigurator<TAttribute, TElement> 
        where TElement : IElement
        where TAttribute : IAttribute
    {
        private readonly TAttribute attribute;
        private readonly TElement element;

        public AttributeConfigurator(TAttribute attribute, TElement element)
        {
            this.attribute = attribute;
            this.element = element;
        }

        public TElement Setup(Action<TAttribute> action)
        {
            action.Invoke(attribute);
            return element;
        }

    }
}
