namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Replacement text for use when images are not available
    /// </summary>
    public sealed class Alt : AttributeBase<string>
    {
        private const string name = "alt";

        public override string AttributeName => name;
    }
}
