using HtmlBuilder;
using HtmlBuilder.Attributes;
using NUnit.Framework;

namespace HtmlBuilder.Test
{
    public class DocumentTest
    {
        [Test]
        public void TestDocument()
        {
            var document = new Document()
                .HtmlContainer
                .AddAttribute(a => a.Lang, l => l.SetValue("en"))
                .AddAttribute(a => a.ItemScope, @is => @is.SetValue(true))
                .AddAttribute(a => a.ItemType, it => it.SetValue("https://schema.org"))
                    .Head
                        .AddChild(e => e.Link)
                        .AddAttribute(a => a.Rel, r => r.SetValue("main.css"))
                .Document.HtmlContainer
                    .Body
                        .AddChild(e => e.Header)
                        .AddChild(e => e.Div)
                        .AddAttribute(d => d.Class, cls => cls.SetValue("main_container"))
                            .AddCustomChild("custom_tag")
                                .AddAttribute(ct => ct.AccessKey, ak => ak.SetValue("custom_key"))
                                .AddCustomAttribute("custom_attribute", "custom_attribute")
                                .AddContent("Text in custom element")
                        .Parent
                            .AddChild(i => i.Img)
                    .Parent.Parent.Parent
                        .AddChild(e => e.Footer)
                .Document
                ;

            var htmlText = document.ToString();

            var testHtmlText =
@"<!DOCTYPE html>
<html lang=""en"" itemscope itemtype=""https://schema.org"">
    <head>
        <link rel=""main.css""/>
    </head>
    <body>
        <header>
            <div class=""main_container"">
                <custom_tag accesskey=""custom_key"" custom_attribute=""custom_attribute"">Text in custom element</custom_tag>
                <img/>
            </div>
        </header>
        <footer/>
    </body>
</html>";

            Assert.IsNotNull(document);
            Assert.IsNotNull(document.HtmlContainer);
            Assert.AreEqual(htmlText, testHtmlText);
        }
    }
}
