using HtmlBuilder;
using HtmlBuilder.Attributes;
using NUnit.Framework;

namespace HtmlBuilderTest
{
    public class ElementTest
    {
        private IElementFactory elementFactory;
        [SetUp]
        public void Setup()
        {
            elementFactory = new ElementFactory();
        }

        [Test]
        public void HtmlElementFactoryTest()
        {
            var element = elementFactory.Create(e => e.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                    .AddChild(e => e.Div)
                    .AddAttribute(a => a.Class, c => c.SetValue("custom_class"))
                .Root;

            var text = element.ToString();

            var testText =
@"<div id=""selector"">
    <div class=""custom_class""/>
</div>";

            Assert.IsNotNull(element);
            Assert.IsNotNull(element.Root);
            Assert.IsNull(element.Parent);
            Assert.AreEqual(text, testText);            
        }

        [Test]
        public void AddCustomChildTest()
        {
            var element = elementFactory.Create(e => e.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                    .AddCustomChild("custom_element")
                .Root;

            var text = element.ToString();

            var testText =
@"<div id=""selector"">
    <custom_element/>
</div>";

            Assert.IsNotNull(element);
            Assert.IsNotNull(element.Root);
            Assert.IsNull(element.Parent);
            Assert.AreEqual(text, testText);
        }

        [Test]
        public void AddCustomAttributeTest()
        {
            var element = elementFactory.Create(e => e.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                .AddCustomAttribute("custom_attribute", "custom_value");

            var text = element.ToString();

            var testText = @"<div id=""selector"" custom_attribute=""custom_value""/>";

            Assert.IsNotNull(element);
            Assert.IsNotNull(element.Root);
            Assert.IsNull(element.Parent);
            Assert.AreEqual(text, testText);
        }

        [Test]
        public void AddContentTest()
        {
            var element = elementFactory.Create(e => e.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                .AddContent("The content");

            var text = element.ToString();

            var testText = @"<div id=""selector"">The content</div>";

            Assert.IsNotNull(element);
            Assert.IsNotNull(element.Root);
            Assert.IsNull(element.Parent);
            Assert.AreEqual(text, testText);
        }

        [Test]
        public void MoreAttributesTest()
        {
            var classes = new[] { "first_class", "second_class" };
            var element = elementFactory.Create(x => x.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                .AddAttribute(a => a.Class, c => c.SetValue(classes))
                .AddAttribute(a => a.Draggable, d => d.SetValue(true))
                .AddCustomAttribute("custom_attribute", "custom_value");

            var text = element.ToString();

            var testText = @"<div id=""selector"" class=""first_class second_class"" draggable custom_attribute=""custom_value""/>";
            
            Assert.IsNotNull(element);
            Assert.IsNotNull(element.Root);
            Assert.IsNull(element.Parent);
            Assert.AreEqual(text, testText);
        }

        [Test]
        public void InsertChildTest()
        {
            var child = elementFactory.Create(e => e.A)
                .AddAttribute(a => a.HRef, r => r.SetValue("https://host.com"));

            Assert.IsNotNull(child);
            Assert.IsNotNull(child.Root);
            Assert.IsNull(child.Parent);

            var element = elementFactory.Create(x => x.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                    .AddChild(child)
                .Root;

            var text = element.ToString();

            var testText =
@"<div id=""selector"">
    <a href=""https://host.com""/>
</div>";

            Assert.IsNotNull(element);
            Assert.IsNotNull(element.Root);
            Assert.IsNull(element.Parent);
            Assert.AreEqual(text, testText);
        }

        [Test]
        public void ChildReferenceTest()
        {

            var element = elementFactory.Create(x => x.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                    .AddChild(e => e.Div, out var child)
                    .AddAttribute(a => a.Class, c => c.SetValue("child_class"))
                        .AddChild(e => e.A)
                        .AddAttribute(a => a.HRef, r => r.SetValue("https://host.com"))
                        .AddContent("The link")  
                    .Parent
                    .AddChild(e => e.Input)
                        .AddAttribute(e => e.FormEncType, fet => fet.SetValue(FormEncTypeValue.Application))
                .Root;

            var childText = child.ToString();


            var childTestText =
@"<div class=""child_class"">
    <a href=""https://host.com"">The link</a>
    <input formenctypevalue=""application/x-www-form-urlencoded""/>
</div>";

            var text = element.ToString();

            var testText =
@"<div id=""selector"">
    <div class=""child_class"">
        <a href=""https://host.com"">The link</a>
        <input formenctypevalue=""application/x-www-form-urlencoded""/>
    </div>
</div>";

            Assert.IsNotNull(child);
            Assert.IsNotNull(child.Root);
            Assert.IsNotNull(child.Parent);            
            Assert.IsNotNull(element);
            Assert.IsNotNull(element.Root);
            Assert.IsNull(element.Parent);
            Assert.AreEqual(child.Root, element.Root);
            Assert.AreEqual(child.Parent, element);            
            Assert.AreEqual(childText, childTestText);
            Assert.AreEqual(text, testText);
        }
    }
}