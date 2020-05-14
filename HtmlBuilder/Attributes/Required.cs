namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the control is required for form submission
    /// </summary>
    public sealed class Required : AttributeBase<bool>
    {
        private const string name = "required";

        public override string AttributeName => name;
    }
}
