namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Browsing context for form submission
    /// </summary>
    public sealed class FormTarget : AttributeBase<string>
    {
        private const string name = "formtarget";

        public override string AttributeName => name;
    }
}
