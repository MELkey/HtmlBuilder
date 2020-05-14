namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// User-visible label
    /// </summary>
    public sealed class Label : AttributeBase<string>
    {
        private const string name = "label";

        public override string AttributeName => name;
    }
}
