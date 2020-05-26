using HtmlBuilder.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Test.Implementations
{
    public class HtmlAttributeBoolTypePrinter : HtmlAttributeValueTypePrinter<bool>
    {
        public override string PrintAttribute(IAttribute<bool> attribute)
        {
            var result = $"{attribute.AttributeName}=\"{attribute.Value}\"";
            return result;
        }
    }
}
