using HtmlBuilder.Attributes;
using HtmlBuilder.Serializer;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;

namespace HtmlBuilder
{
    public abstract class ElementBase : IElement
    {        
        private readonly IElement root;

        private protected readonly IHtmlSerializerFactory serializerFactory;
        private protected string name;
        private protected List<IElement> childs = new List<IElement>();
        private protected List<IAttribute> attributes = new List<IAttribute>();
        private protected List<string> content = new List<string>();

        public string Name => name;
        public IReadOnlyCollection<IElement> Childs => new ReadOnlyCollection<IElement>(childs);
        public IReadOnlyCollection<IAttribute> Attributes => new ReadOnlyCollection<IAttribute>(attributes);
        public IReadOnlyCollection<string> Content => new ReadOnlyCollection<string>(content);
        public IElement Root { get => root ?? this; }
        public IElement Parent { get; }
        public Document Document { get; }

        internal ElementBase(Document document, IElement root, IElement parrent, IHtmlSerializerFactory serializerFactory)
        {
            Document = document;
            Parent = parrent;
            this.root = root;
            this.serializerFactory = serializerFactory;
        }


        public override string ToString()
        {
            using (var stringWriter = new StringWriter())
            {
                var serializer = serializerFactory.Create(this);
                serializer.Serialize(stringWriter);
                var result = stringWriter.ToString();
                return result;
            }
        }
    }
}
