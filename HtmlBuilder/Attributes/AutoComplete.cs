namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Hint for form autofill feature
    /// </summary>
    public sealed class AutoComplete : AttributeBase<string>
    {
        private const string name = "autocomplete";

        public override string AttributeName => name;
    }
}
