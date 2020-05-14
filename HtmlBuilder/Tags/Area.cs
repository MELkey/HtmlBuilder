using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Hyperlink or dead area on an image map
    /// </summary>
    public class Area : GlobalElement
    {
        private const string name = "area";
        public override string TagName => name;

        /// <summary>
        /// Replacement text for use when images are not available
        /// </summary>
        public Alt Alt { get; set; }

        /// <summary>
        /// Coordinates for the shape to be created in an image map
        /// </summary>
        public Coords Coords { get; set; }

        /// <summary>
        /// The kind of shape to be created in an image map
        /// </summary>
        public Shape Shape { get; set; }

        /// <summary>
        /// Address of the hyperlink
        /// </summary>
        public HRef HRef { get; set; }

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
        /// Referrer policy for fetches initiated by the element
        /// </summary>
        public ReferrerPolicy ReferrerPolicy { get; set; }
    }
}
