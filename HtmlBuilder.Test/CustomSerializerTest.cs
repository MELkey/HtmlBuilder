using HtmlBuilder.Serializer;
using HtmlBuilder.Test.Implementations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Test
{
    [TestFixture]
    public class CustomSerializerTest
    {
        private IHtmlSerializerFactory serializerFactory;
        private IElementFactory elementFactory;

        [SetUp]
        public void SetUp()
        {
            var settings = new HtmlSerializerSettings();
            settings.AddAttributeValueTypeSerializer(new HtmlAttributeBoolTypePrinter());
            settings.AddAttributeSerializer(new HtmlAttributeUpCaseClassAttribute());

            serializerFactory = new HtmlSerializerFactory(settings);
            elementFactory = new ElementFactory();
        }

        [Test]
        public void CustomSerialaizeAttributeValueTypeTest()
        {
            var document = new Document(serializerFactory)
                .Html
                .AddAttribute(a => a.Lang).Setup(l => l.SetValue("en"))
                .AddAttribute(a => a.ItemScope).Setup(@is => @is.SetValue(true))
                .Document;

            var text = document.ToString();
            var testText =
 $@"<!DOCTYPE html>
<html lang=""en"" itemscope=""True"">
    <head/>
    <body/>
</html>";
            Assert.IsNotNull(text);
            Assert.AreEqual(text, testText);
        }

        [Test]
        public void CustomSerialaizeAttributeTest()
        {
            var element = elementFactory.Create(e => e.Div, serializerFactory)
                            .AddAttribute(a => a.Id).Setup(i => i.SetValue("selector"))
                                .AddChild(e => e.Div)
                                .AddAttribute(a => a.Class).Setup(c => c.SetValue(new[] { "custom_class", "custom_class2" }))
                            .Root;

            var text = element.ToString();

            var testText =
@"<div id=""selector"">
    <div class=""CUSTOM_CLASS CUSTOM_CLASS2""/>
</div>";

            Assert.IsNotNull(element);
            Assert.IsNotNull(element.Root);
            Assert.IsNull(element.Parent);
            Assert.AreEqual(text, testText);
        }
    }
}
