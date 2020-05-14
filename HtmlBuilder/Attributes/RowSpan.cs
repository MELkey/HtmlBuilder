namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Number of rows that the cell is to span
    /// </summary>
    public sealed class RowSpan : AttributeBase<uint>
    {
        private const string name = "rowspan";

        public override string AttributeName => name;
    }
}
