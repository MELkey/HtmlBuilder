namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Maximum number of characters per line
    /// </summary>
    public sealed class Cols : AttributeBase<uint>
    {
        private const string name = "cols";

        public override string AttributeName => name;
    }
}
