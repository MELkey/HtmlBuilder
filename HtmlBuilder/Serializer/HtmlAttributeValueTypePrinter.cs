using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public abstract class HtmlAttributeValueTypePrinter<TValue> : IHtmlAttributeValueTypePrinter
    {
        public abstract string PrintAttribute(IAttribute<TValue> attribute);

        string IHtmlAttributeValueTypePrinter.PrintAttribute(IAttribute attribute)
        {
            return PrintAttribute(attribute as IAttribute<TValue>);
        }
    }
}
