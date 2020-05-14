namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Number of lines to show
    /// </summary>
    public sealed class Rows : AttributeBase<uint>
    {
        private const string name = "rows";

        public override string AttributeName => name;
    }
}
