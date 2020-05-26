using HtmlBuilder.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HtmlBuilder.Serializer
{
    public class HtmlAttributePrinterDefault
    {
        public string Print(IAttribute attribute)
        {
            var type = attribute.Value.GetType();
            if (type.IsArray)
                return GetStringValueFromArray(attribute);
            else if (type.GetTypeInfo().IsEnum)
                return GetStringValueFromEnum(attribute);
            else if (type == typeof(bool))
                return GetBoolValue(attribute);
            else
                return GetDefaultValue(attribute);
        }

        private string GetDefaultValue(IAttribute attribute)
        {
            var result = Combine(attribute.AttributeName, attribute.Value.ToString());
            return result;
        }        

        private string GetStringValueFromArray(IAttribute attribute)
        {
            var array = ((IEnumerable<object>)attribute.Value).Select(x => x.ToString());
            var value = string.Join(" ", array);
            var result = Combine(attribute.AttributeName, value);

            return result;
        }

        private string GetStringValueFromEnum(IAttribute attribute)
        {
            var value = ((Enum)attribute.Value).GetDescription();
            var result = Combine(attribute.AttributeName, value);

            return result;
        }

        private string GetBoolValue(IAttribute attribute)
        {
            var result = (bool)attribute.Value ?
                attribute.AttributeName :
                string.Empty;

            return result;
        }

        private string Combine(string name, string value)
        {
            var result = $"{name}=\"{value}\"";
            return result;
        }
    }
}
