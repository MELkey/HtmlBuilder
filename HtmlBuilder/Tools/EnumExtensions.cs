using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace HtmlBuilder.Tools
{
    static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetRuntimeField(value.ToString());

            var attributes = fieldInfo
                .GetCustomAttributes(typeof(DescriptionAttribute), false) 
                as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
                return attributes.First().Description;

            return value.ToString();
        }
    }
}
