using HtmlBuilder.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HtmlBuilder.Serializer
{
    public partial class HtmlSerializer : IHtmlSerializerAsync
    {
        private readonly HtmlAttributePrinterDefault attributePrinterDefault = new HtmlAttributePrinterDefault();
        private readonly IHtmlSerializerSettings settings;
        private readonly IReadOnlyDictionary<Type, IHtmlAttributeValueTypePrinter> attributeValueTypeSerializers;
        private readonly IReadOnlyDictionary<Type, IHtmlAttributePrinter> attributeSerializers;

        private readonly IElement element;
        private readonly Document document;


        public HtmlSerializer(IElement element)
            : this(element, new HtmlSerializerSettings())
        {
        }

        public HtmlSerializer(Document document)
            : this(document, new HtmlSerializerSettings())
        {
        }

        public HtmlSerializer(IElement element, IHtmlSerializerSettings settings)
        {
            this.element = element ?? throw new ArgumentNullException(nameof(element));
            this.settings = settings ?? throw new ArgumentNullException(nameof(settings));
            this.attributeSerializers = settings.AttributeSerializers;
            this.attributeValueTypeSerializers = settings.AttributeValueTypeSerializers;
        }

        public HtmlSerializer(Document document, IHtmlSerializerSettings settings)
        {
            this.document = document ?? throw new ArgumentNullException(nameof(document));
            this.element = document.Html ?? throw new ArgumentNullException(nameof(document.Html));
            this.settings = settings ?? throw new ArgumentNullException(nameof(settings));
            this.attributeSerializers = settings.AttributeSerializers;
            this.attributeValueTypeSerializers = settings.AttributeValueTypeSerializers;
        }

        public void Serialize(TextWriter textWriter)
        {
            if (document != null)
            {
                textWriter.Write(document.TypeValue);
                textWriter.WriteLine();
            }

            SerializeElement(element, textWriter);
        }

        private void SerializeElement(IElement element, TextWriter textWriter)
        {
            if (element != this.element)
                textWriter.WriteLine();

            OpenTag(element, textWriter);
            var isInline = element.IsInline();

            if (!isInline)
                foreach (var child in element.Childs)
                    SerializeElement(child, textWriter);

            AddContent(element, textWriter);

            if (!isInline)
                textWriter.WriteLine();

            CloseTag(element, textWriter);
        }

        private void OpenTag(IElement element, TextWriter textWriter)
        {
            AddIndent(element, textWriter);
            textWriter.Write(settings.Tokens.Open);
            textWriter.Write(element.Name);

            var attributes = element.Attributes;

            if (attributes.Count > 0)
                AddAttributes(attributes, textWriter);

            if (!NeedUseCompactStyle(element))
                textWriter.Write(settings.Tokens.Close);
        }

        private void CloseTag(IElement element, TextWriter textWriter)
        {
            if (!element.IsInline())
                AddIndent(element, textWriter);

            if (NeedUseCompactStyle(element))
                CloseTagCompact(textWriter);
            else
                CloseTagUnCompact(element, textWriter);
        }

        private void CloseTagCompact(TextWriter textWriter)
        {
            textWriter.Write(settings.Tokens.ClosePrefix);
            textWriter.Write(settings.Tokens.Close);
        }

        private void CloseTagUnCompact(IElement element, TextWriter textWriter)
        {
            textWriter.Write(settings.Tokens.Open);
            textWriter.Write(settings.Tokens.ClosePrefix);
            textWriter.Write(element.Name);
            textWriter.Write(settings.Tokens.Close);
        }

        private void AddIndent(IElement element, TextWriter textWriter)
        {
            var deep = settings.UseParrentIndent ?
                element.CalculateDeep() :
                element.CalculateDeep() - this.element.CalculateDeep();

            foreach (var level in Enumerable.Range(0, deep))
                foreach (var step in Enumerable.Range(0, settings.IndentCount))
                    textWriter.Write(settings.Tokens.Indent);
        }

        private void AddAttributes(IReadOnlyCollection<IAttribute> attributes, TextWriter textWriter)
        {
            foreach (var attribute in attributes)
            {
                var stringValue = PrintAttribute(attribute);
                if (string.IsNullOrEmpty(stringValue))
                    continue;

                textWriter.Write(settings.Tokens.WhiteSpace);
                textWriter.Write(stringValue);
            }
        }

        private string PrintAttribute(IAttribute attribute)
        {
            var attributeType = attribute.GetType();
            if (attributeSerializers.ContainsKey(attributeType))
                return attributeSerializers[attributeType].PrintAttribute(attribute);

            var valueType = attribute.Value.GetType();
            if (attributeValueTypeSerializers.ContainsKey(valueType))
                return attributeValueTypeSerializers[valueType].PrintAttribute(attribute);

            return attributePrinterDefault.Print(attribute);
        }

        private void AddContent(IElement element, TextWriter textWriter)
        {
            var content = element.Content;
            var hasContent = content.Count > 0;

            if (!hasContent)
                return;

            var isInline = element.IsInline();

            if (hasContent && !isInline)
                textWriter.WriteLine();

            if (isInline)
            {
                textWriter.Write(content.First());
            }
            else
            {
                foreach (var contentElement in content)
                {
                    AddIndent(element, textWriter);
                    textWriter.Write(contentElement);
                    textWriter.WriteLine();
                }
            }
        }

        private bool NeedUseCompactStyle(IElement element)
        {
            return settings.UseCompactStyle && element.IsEmpty();
        }
    }
}
