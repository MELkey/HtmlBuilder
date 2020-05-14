namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// URL to use for form submission
    /// </summary>
    public sealed class FormAction : AttributeBase<string>
    {
        private const string name = "formaction";

        public override string AttributeName => name;
    }
}
