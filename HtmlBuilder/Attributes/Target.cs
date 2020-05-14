namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Browsing context
    /// </summary>
    public sealed class Target : AttributeBase<string>
    {
        private const string name = "target";

        public override string AttributeName => name;
    }
}
