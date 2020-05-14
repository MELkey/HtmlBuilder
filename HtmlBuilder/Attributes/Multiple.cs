namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether to allow multiple values
    /// </summary>
    public sealed class Multiple : AttributeBase<bool>
    {
        private const string name = "multiple";

        public override string AttributeName => name;
    }
}
