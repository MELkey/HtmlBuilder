using HtmlBuilder.Serializer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlBuilder.Test
{
    public class SerializerTest
    {
        private IHtmlSerializerFactory serializerFactory;
        private IElementFactory elementFactory;

        [SetUp]
        public void SetUp()
        {
            serializerFactory = new HtmlSerializerFactory();
            elementFactory = new ElementFactory();
        }

        [Test]
        public void SerializeTextTest()
        {
            var element = elementFactory.Create(x => x.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                    .AddChild(e => e.Div, out var child)
                    .AddAttribute(a => a.Class, c => c.SetValue("child_class"))
                        .AddChild(e => e.A)
                        .AddAttribute(a => a.HRef, r => r.SetValue("https://host.com"))
                        .AddContent("The link")
                .Root;

            var result = string.Empty;

            using(var sw = new StringWriter())
            {
                var serializer = serializerFactory.Create(element);
                serializer.Serialize(sw);
                result = sw.ToString();
            }
        }
    }
}
