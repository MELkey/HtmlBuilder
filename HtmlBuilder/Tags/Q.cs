namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Quotation
    /// </summary>
    public class Q : GlobalElement
    {
        private const string name = "q";
        public override string TagName => name;

        /// <summary>
        /// Link to the source of the quotation or more information about the edit
        /// </summary>
        public Attributes.Cite Cite { get; set; }
    }
}
