using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public class HtmlSerializerFactory : IHtmlSerializerFactory
    {
        private readonly IHtmlSerializerSettings settings;

        public HtmlSerializerFactory()
        {
            this.settings = new HtmlSerializerSettings();
        }

        public HtmlSerializerFactory(IHtmlSerializerSettings settings)
        {
            this.settings = settings;
        }

        public IHtmlSerializer Create(Document document)
        {
            return new HtmlSerializer(document, settings);
        }

        public IHtmlSerializer Create(IElement element)
        {
            return new HtmlSerializer(element, settings);
        }
    }
}
