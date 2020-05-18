using HtmlBuilder.Serializer;
using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;

namespace HtmlBuilder.Test
{
    public class SerializerTest
    {
        private readonly string file = "Document.html";
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
                .AddAttribute(a => a.Id).UseActionAttribute(i => i.SetValue("selector"))
                    .AddChild(e => e.Div, out var child)
                    .AddAttribute(a => a.Class).UseActionAttribute(c => c.SetValue("child_class"))
                        .AddChild(e => e.A)
                        .AddAttribute(a => a.HRef).UseActionAttribute(r => r.SetValue("https://host.com"))
                        .AddContent("The link")
                .Root;

            var result = string.Empty;

            using(var sw = new StringWriter())
            {
                var serializer = serializerFactory.Create(element);
                serializer.Serialize(sw);
                result = sw.ToString();
            }
            var testResult = 
@"<div id=""selector"">
    <div class=""child_class"">
        <a href=""https://host.com"">The link</a>
    </div>
</div>";
            Assert.AreEqual(result, testResult); 
        }

        [Test]
        public void SaveToFileTest()
        {
            var document = new Document()
                .Html
                .AddAttribute(a => a.Lang).UseActionAttribute(l => l.SetValue("en"))
                .AddAttribute(a => a.ItemScope).UseActionAttribute(@is => @is.SetValue(true))
                .AddAttribute(a => a.ItemType).UseActionAttribute(it => it.SetValue("https://schema.org"))
                .Document.Head
                        .AddChild(e => e.Link)
                        .AddAttribute(a => a.Rel).UseActionAttribute(r => r.SetValue("main.css"))
                .Document.Body
                        .AddChild(e => e.Header)
                        .AddChild(e => e.Div)
                        .AddAttribute(d => d.Class).UseActionAttribute(cls => cls.SetValue("main_container"))
                            .AddCustomChild("custom_tag")
                                .AddAttribute(ct => ct.AccessKey).UseActionAttribute(ak => ak.SetValue("custom_key"))
                                .AddCustomAttribute("custom_attribute", "custom_attribute")
                                .AddContent("Text in custom element")
                        .Parent
                            .AddChild(i => i.Img)
                    .Parent.Parent.Parent
                        .AddChild(e => e.Footer)
                .Document
                ;
            using (var fileStream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    var serializer = new HtmlSerializer(document);
                    serializer.Serialize(streamWriter);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }

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
            var result = string.Empty;
            using (var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    result = streamReader.ReadToEnd();
                    streamReader.Close();
                }
            }

            Assert.AreEqual(result, testHtmlText);
        }

        [Test]
        public async Task SaveToFileTestAsync()
        {
            var document = new Document()
                .Html
                .AddAttribute(a => a.Lang).UseActionAttribute(l => l.SetValue("en"))
                .AddAttribute(a => a.ItemScope).UseActionAttribute(@is => @is.SetValue(true))
                .AddAttribute(a => a.ItemType).UseActionAttribute(it => it.SetValue("https://schema.org"))
                .Document.Head
                        .AddChild(e => e.Link)
                        .AddAttribute(a => a.Rel).UseActionAttribute(r => r.SetValue("main.css"))
                .Document.Body
                        .AddChild(e => e.Header)
                        .AddChild(e => e.Div)
                        .AddAttribute(d => d.Class).UseActionAttribute(cls => cls.SetValue("main_container"))
                            .AddCustomChild("custom_tag")
                                .AddAttribute(ct => ct.AccessKey).UseActionAttribute(ak => ak.SetValue("custom_key"))
                                .AddCustomAttribute("custom_attribute", "custom_attribute")
                                .AddContent("Text in custom element")
                        .Parent
                            .AddChild(i => i.Img)
                    .Parent.Parent.Parent
                        .AddChild(e => e.Footer)
                .Document
                ;

            using (var fileStream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    var serializer = new HtmlSerializer(document);
                    await serializer.SerializeAsync(streamWriter).ConfigureAwait(false);
                    await streamWriter.FlushAsync().ConfigureAwait(false);
                    streamWriter.Close();
                }
            }

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
            var result = string.Empty;
            using (var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    result = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                    streamReader.Close();
                }
            }

            Assert.AreEqual(result, testHtmlText);
        }
    }
}
