namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the option is selected by default
    /// </summary>
    public sealed class Selected : AttributeBase<bool>
    {
        private const string name = "selected";

        public override string AttributeName => name;
    }
}
