using HtmlBuilder.Serializer;
using HtmlBuilder.Tools;
using System.IO;

namespace HtmlBuilder
{
    public class Document
    {
        private readonly IHtmlSerializerFactory serializerFactory;
        public string TypeValue { get; }

        public HtmlContainer HtmlContainer { get; }

        public Document(DocumentType documentType = DocumentType.Html5)
        {
            this.serializerFactory = new HtmlSerializerFactory();
            TypeValue = documentType.GetDescription();
            HtmlContainer = new HtmlContainer(this);
        }

        public Document(string typeValue)
        {
            this.serializerFactory = new HtmlSerializerFactory();
            TypeValue = typeValue;
            HtmlContainer = new HtmlContainer(this);
        }

        public Document(IHtmlSerializerFactory serializerFactory, DocumentType documentType = DocumentType.Html5)
        {
            this.serializerFactory = serializerFactory;
            TypeValue = documentType.GetDescription();
            HtmlContainer = new HtmlContainer(this);
        }

        public Document(IHtmlSerializerFactory serializerFactory, string typeValue)
        {
            this.serializerFactory = serializerFactory;
            TypeValue = typeValue;
            HtmlContainer = new HtmlContainer(this);
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
