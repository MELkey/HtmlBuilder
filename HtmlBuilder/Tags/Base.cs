using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Base URL and default target browsing context for hyperlinks and forms
    /// </summary>
    public class Base : GlobalElement
    {
        private const string name = "base";
        public override string TagName => name;

        /// <summary>
        /// Address of the hyperlink
        /// </summary>
        public HRef Href { get; set; }

        /// <summary>
        /// Browsing context
        /// </summary>
        public Target Target { get; set; }
    }
}
