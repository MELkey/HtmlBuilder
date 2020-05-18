using HtmlBuilder.Serializer;
using HtmlBuilder.Tags;
using HtmlBuilder.Tools;
using System.IO;

namespace HtmlBuilder
{
    public class Document
    {
        private readonly IHtmlSerializerFactory serializerFactory;
        public string TypeValue { get; }
        public IElement<Html, IElement> Html { get; }
        public IElement<Head, IElement<Html, IElement>> Head { get; }
        public IElement<Body, IElement<Html, IElement>> Body { get; }

        public Document(DocumentType documentType = DocumentType.Html5)
        {
            this.serializerFactory = new HtmlSerializerFactory();
            TypeValue = documentType.GetDescription();
            var html = default(Element<Html, IElement>);
            html = new Element<Html, IElement>(this, html, null, serializerFactory);
            Html = html;
            Head = html.AddChild(x => x.Head);
            Body = html.AddChild(x => x.Body);
        }

        public Document(string typeValue)
        {
            this.serializerFactory = new HtmlSerializerFactory();
            TypeValue = typeValue;
            var html = default(Element<Html, IElement>);
            html = new Element<Html, IElement>(this, html, null, serializerFactory);
            Html = html;
            Head = html.AddChild(x => x.Head);
            Body = html.AddChild(x => x.Body);
        }

        public Document(IHtmlSerializerFactory serializerFactory, DocumentType documentType = DocumentType.Html5)
        {
            this.serializerFactory = serializerFactory;
            TypeValue = documentType.GetDescription();
            var html = default(Element<Html, IElement>);
            html = new Element<Html, IElement>(this, html, null, serializerFactory);
            Html = html;
            Head = html.AddChild(x => x.Head);
            Body = html.AddChild(x => x.Body);
        }

        public Document(IHtmlSerializerFactory serializerFactory, string typeValue)
        {
            this.serializerFactory = serializerFactory;
            TypeValue = typeValue;
            var html = default(Element<Html, IElement>);
            html = new Element<Html, IElement>(this, html, null, serializerFactory);
            Html = html;
            Head = html.AddChild(x => x.Head);
            Body = html.AddChild(x => x.Body);
        }

        public override string ToString()
        {
            using (var stringWriter = new StringWriter())
            {
                var serializer = serializerFactory.Create(this);
                serializer.Serialize(stringWriter);
                var result = stringWriter.ToString();
                stringWriter.Flush();
                return result;
            }
        }
    }
}
