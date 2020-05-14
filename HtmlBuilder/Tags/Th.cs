using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Table header cell
    /// </summary>
    public class Th : GlobalElement
    {
        private const string name = "th";
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

        /// <summary>
        /// Specifies which cells the header cell applies to
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Alternative label to use for the header cell when referencing the cell in other contexts
        /// </summary>
        public Attributes.Abbr Abbr { get; set; }
    }
}
