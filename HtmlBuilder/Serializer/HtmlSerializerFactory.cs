using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public class HtmlSerializerFactory : IHtmlSerializerFactory
    {
        private readonly IHtmlAttributePrinter htmlAttributePrinter;
        private readonly IHtmlSerializerSettings settings;

        public HtmlSerializerFactory()
        {
            this.htmlAttributePrinter = new HtmlAttributePrinter();
            this.settings = new HtmlSerializerSettings();
        }

        public HtmlSerializerFactory(IHtmlAttributePrinter htmlAttributePrinter)
        {
            this.htmlAttributePrinter = htmlAttributePrinter;
            this.settings = new HtmlSerializerSettings();
        }

        public HtmlSerializerFactory(IHtmlSerializerSettings settings)
        {
            this.htmlAttributePrinter = new HtmlAttributePrinter();
            this.settings = settings;
        }

        public HtmlSerializerFactory(IHtmlAttributePrinter htmlAttributePrinter, IHtmlSerializerSettings settings)
        {
            this.htmlAttributePrinter = htmlAttributePrinter;
            this.settings = settings;
        }

        public IHtmlSerializer Create(Document document)
        {
            return new HtmlSerializer(document, htmlAttributePrinter, settings);
        }

        public IHtmlSerializer Create(IElement element)
        {
            return new HtmlSerializer(element, htmlAttributePrinter, settings);
        }
    }
}
