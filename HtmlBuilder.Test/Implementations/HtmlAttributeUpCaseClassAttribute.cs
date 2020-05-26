using HtmlBuilder.Attributes;
using HtmlBuilder.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlBuilder.Test.Implementations
{
    public class HtmlAttributeUpCaseClassAttribute : HtmlAttributePrinter<Class>
    {
        public override string PrintAttribute(Class attribute)
        {
            var value = (string[])attribute.Value;
            return $"{attribute.AttributeName}=\"{string.Join(" ", value.Select(x => x.ToUpper()))}\"";
        }
    }
}
