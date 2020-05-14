namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Associates the element with a form element
    /// </summary>
    public sealed class Form : AttributeBase<string>
    {
        private const string name = "form";

        public override string AttributeName => name;
    }
}
