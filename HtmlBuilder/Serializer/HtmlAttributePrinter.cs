using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public abstract class HtmlAttributePrinter<TAttribute> : IHtmlAttributePrinter
        where TAttribute : IAttribute
    {
        public abstract string PrintAttribute(TAttribute attribute);

        string IHtmlAttributePrinter.PrintAttribute(IAttribute attribute)
        {
            return PrintAttribute((TAttribute)attribute);
        }
    }
}
