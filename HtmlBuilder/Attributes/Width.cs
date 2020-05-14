namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Horizontal dimension
    /// </summary>
    public sealed class Width : AttributeBase<uint>
    {
        private const string name = "width";

        public override string AttributeName => name;
    }
}
