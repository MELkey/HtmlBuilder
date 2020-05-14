using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Table cell
    /// </summary>
    public class Td : GlobalElement
    {
        private const string name = "td";
        public override string TagName => name;

        /// <summary>
        /// Number of columns that the cell is to span
        /// </summary>
        public ColSpan ColSpan { get; set; }

        /// <summary>
        /// Number of rows that the cell is to span
        /// </summary>
        public RowSpan RowSpan { get; set; }

        /// <summary>
        /// The header cells for this cell
        /// </summary>
        public Headers Headers { get; set; }
    }
}
