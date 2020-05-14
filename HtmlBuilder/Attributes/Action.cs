namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// URL to use for form submission
    /// </summary>
    public sealed class Action : AttributeBase<string>
    {
        private const string name = "action";

        public override string AttributeName => name;
    }
}
