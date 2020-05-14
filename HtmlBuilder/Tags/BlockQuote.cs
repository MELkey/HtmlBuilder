namespace HtmlBuilder.Tags
{
    /// <summary>
    /// A section quoted from another source
    /// </summary>
    public class BlockQuote : GlobalElement
    {
        private const string name = "blockquote";
        public override string TagName => name;

        /// <summary>
        /// Link to the source of the quotation or more information about the edit
        /// </summary>
        public Attributes.Cite Cite { get; set; }
    }
}
