namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Default setting for autofill feature for controls in the form
    /// </summary>
    public sealed class AutoCompleteForm : AttributeBase<AutoCompleteFormValues>
    {
        private const string name = "autocomplete";

        public override string AttributeName => name;
    }
}
