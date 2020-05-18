using HtmlBuilder.Attributes;
using HtmlBuilder.Serializer;
using HtmlBuilder.Tags;
using System;
using System.Linq.Expressions;

namespace HtmlBuilder
{
    public class HtmlContainer
    {
        public IElement<Html, IElement> Html { get; }
        public IElement<Head, IElement<Html, IElement>> Head { get; }
        public IElement<Body, IElement<Html, IElement>> Body { get; }

        public HtmlContainer()
            : this(default(Document))
        {
        }

        public HtmlContainer(IHtmlSerializerFactory serializerFactory)
            : this(null, serializerFactory)
        {
        }

        internal HtmlContainer(Document document)
        {
            var serializerFactory = new HtmlSerializerFactory();
            var html = default(Element<Html, IElement>);
            html = new Element<Html, IElement>(document, html, null, serializerFactory);
            Html = html;
            Head = html.AddChild(x => x.Head);
            Body = html.AddChild(x => x.Body);
        }

        internal HtmlContainer(Document document, IHtmlSerializerFactory serializerFactory)
        {
            var html = default(Element<Html, IElement>);
            html = new Element<Html, IElement>(document, html, null, serializerFactory);
            Html = html;
            Head = html.AddChild(x => x.Head);
            Body = html.AddChild(x => x.Body);
        }

        public HtmlContainer AddAttribute<TAttribute>(
            Expression<Func<Html, TAttribute>> attributeSelector,
            Expression<Action<TAttribute>> valueAction)
            where TAttribute : IAttribute, new()
        {
            Html.AddAttribute(attributeSelector, valueAction);
            return this;
        }

        public HtmlContainer AddCustomAttribute(string name, string value)
        {
            Html.AddCustomAttribute(name, value);
            return this;
        }

        public override string ToString()
        {
            return Html.ToString();
        }
    }
}
