namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Number of columns that the cell is to span
    /// </summary>
    public sealed class ColSpan : AttributeBase<uint>
    {
        private const string name = "colspan";

        public override string AttributeName => name;
    }
}
