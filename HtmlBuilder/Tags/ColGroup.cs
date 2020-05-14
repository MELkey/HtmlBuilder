namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Group of columns in a table
    /// </summary>
    public class ColGroup : GlobalElement
    {
        private const string name = "colgroup";
        public override string TagName => name;

        /// <summary>
        /// Number of columns spanned by the element
        /// </summary>
        public Attributes.Span Span { get; set; }
    }
}
