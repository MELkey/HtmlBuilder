namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Value
    /// </summary>
    public sealed class Value : AttributeBase<string>
    {
        private const string name = "value";

        public override string AttributeName => name;
    }
}
