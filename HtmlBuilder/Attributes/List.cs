namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// List of autocomplete options
    /// </summary>
    public sealed class List : AttributeBase<string>
    {
        private const string name = "list";

        public override string AttributeName => name;
    }
}
