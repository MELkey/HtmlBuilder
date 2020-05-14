namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Bypass form control validation for form submission
    /// </summary>
    public sealed class FormNoValidate : AttributeBase<bool>
    {
        private const string name = "formnovalidate";

        public override string AttributeName => name;
    }
}
