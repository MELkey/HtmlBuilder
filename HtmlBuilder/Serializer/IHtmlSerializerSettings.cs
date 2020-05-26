using System;
using System.Collections.Generic;

namespace HtmlBuilder.Serializer
{
    public interface IHtmlSerializerSettings
    {
        int IndentCount { get; }

        ITokens Tokens { get; }

        /// <summary>
        /// Use compact style for empty tags.
        /// </summary>
        bool UseCompactStyle { get; }

        /// <summary>
        /// Use indentation, taking into account the indentation for the parent.
        /// </summary>
        bool UseParrentIndent { get; }

        IReadOnlyDictionary<Type, IHtmlAttributeValueTypePrinter> AttributeValueTypeSerializers { get; }

        IReadOnlyDictionary<Type, IHtmlAttributePrinter> AttributeSerializers { get; }

        void AddAttributeValueTypeSerializer<TValue>(HtmlAttributeValueTypePrinter<TValue> attributeValueTypeSerializer);

        void AddAttributeSerializer<TAttribute>(HtmlAttributePrinter<TAttribute> attributeSerializer)
            where TAttribute : IAttribute;
    }
}