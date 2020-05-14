namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Show user agent controls
    /// </summary>
    public sealed class Controls : AttributeBase<bool>
    {
        private const string name = "controls";

        public override string AttributeName => name;
    }
}
