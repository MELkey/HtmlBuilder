using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public class HtmlSerializerSettings : IHtmlSerializerSettings
    {
        private readonly Dictionary<Type, IHtmlAttributeValueTypePrinter> attributeValueTypeSerializers =
            new Dictionary<Type, IHtmlAttributeValueTypePrinter>();

        private readonly Dictionary<Type, IHtmlAttributePrinter> attributeSerializers =
            new Dictionary<Type, IHtmlAttributePrinter>();

        public HtmlSerializerSettings()
            : this(
                  indentCount: 4,
                  useParrentIndent: false,
                  useCompactStyle: true,
                  tokens: new Tokens())
        {
        }

        public HtmlSerializerSettings(int indentCount, bool useParrentIndent, bool useCompactStyle, ITokens tokens)
        {
            IndentCount = indentCount;
            UseParrentIndent = useParrentIndent;
            UseCompactStyle = useCompactStyle;
            Tokens = tokens ?? throw new ArgumentNullException(nameof(tokens));
        }

        public int IndentCount { get; }        
        public bool UseParrentIndent { get; }        
        public bool UseCompactStyle { get; }
        public ITokens Tokens { get; }

        public IReadOnlyDictionary<Type, IHtmlAttributeValueTypePrinter> AttributeValueTypeSerializers => 
            new ReadOnlyDictionary<Type, IHtmlAttributeValueTypePrinter>(attributeValueTypeSerializers);

        public IReadOnlyDictionary<Type, IHtmlAttributePrinter> AttributeSerializers =>
            new ReadOnlyDictionary<Type, IHtmlAttributePrinter>(attributeSerializers);

        public void AddAttributeValueTypeSerializer<TValue>(HtmlAttributeValueTypePrinter<TValue> attributeValueTypeSerializer)
        {
            attributeValueTypeSerializers[typeof(TValue)] = attributeValueTypeSerializer;
        }

        public void AddAttributeSerializer<TAttribute>(HtmlAttributePrinter<TAttribute> attributeSerializer)
            where TAttribute : IAttribute
        {
            attributeSerializers[typeof(TAttribute)] = attributeSerializer;
        }
    }
}
