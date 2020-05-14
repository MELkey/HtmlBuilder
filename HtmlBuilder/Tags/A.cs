using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Hyperlink
    /// </summary>
    public class A : GlobalElement
    {
        private const string name = "a";
        public override string TagName => name;

        /// <summary>
        /// Browsing context
        /// </summary>
        public Target Target { get; set; }

        /// <summary>
        /// Whether to download the resource instead of navigating to it, and its file name if so
        /// </summary>
        public Download Download { get; set; }

        /// <summary>
        /// URLs to ping
        /// </summary>
        public Ping Ping { get; set; }

        /// <summary>
        /// Relationship between the location in the document containing the hyperlink and the destination resourc
        /// </summary>
        public Rel Rel { get; set; }

        /// <summary>
        /// Language of the linked resource
        /// </summary>
        public HRefLang HRefLang { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public Attributes.Type Type { get; set; }

        /// <summary>
        /// Address of the hyperlink
        /// </summary>
        public HRef HRef { get; set; }

        /// <summary>
        /// Referrer policy for fetches initiated by the element
        /// </summary>
        public ReferrerPolicy ReferrerPolicy { get; set; }
    }
}
