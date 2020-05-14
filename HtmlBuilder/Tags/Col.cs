namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Table column
    /// </summary>
    public class Col : GlobalElement
    {
        private const string name = "col";
        public override string TagName => name;

        /// <summary>
        /// Number of columns spanned by the element
        /// </summary>
        public Attributes.Span Span { get; set; }
    }
}
