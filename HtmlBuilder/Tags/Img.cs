using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Image
    /// </summary>
    public class Img : GlobalElement
    {
        private const string name = "img";
        public override string TagName => name;

        /// <summary>
        /// Replacement text for use when images are not available
        /// </summary>
        public Alt Alt { get; set; }

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// Images to use in different situations (e.g., high-resolution displays, small monitors, etc.)
        /// </summary>
        public SrcSet SrcSet { get; set; }

        /// <summary>
        /// Image sizes for different page layouts
        /// </summary>
        public Sizes Sizes { get; set; }

        /// <summary>
        /// How the element handles crossorigin requests
        /// </summary>
        public CrossOrigin CrossOrigin { get; set; }

        /// <summary>
        /// Name of image map to use
        /// </summary>
        public UseMap UseMap { get; set; }

        /// <summary>
        /// Whether the image is a server-side image map
        /// </summary>
        public IsMap IsMap { get; set; }

        /// <summary>
        /// Horizontal dimension
        /// </summary>
        public Width Width { get; set; }

        /// <summary>
        /// Vertical dimension
        /// </summary>
        public Height Height { get; set; }

        /// <summary>
        /// Decoding hint to use when processing this image for presentation
        /// </summary>
        public Decoding Decoding { get; set; }

        /// <summary>
        /// Referrer policy for fetches initiated by the element
        /// </summary>
        public ReferrerPolicy ReferrerPolicy { get; set; }
    }
}
