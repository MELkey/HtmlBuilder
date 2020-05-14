using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Image source for img or media source for video or audio
    /// </summary>
    public class Source : GlobalElement
    {
        private const string name = "source";
        public override string TagName => name;

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public Attributes.Type Type { get; set; }

        /// <summary>
        /// Images to use in different situations (e.g., high-resolution displays, small monitors, etc.)
        /// </summary>
        public SrcSet SrcSet { get; set; }

        /// <summary>
        /// Image sizes for different page layouts
        /// </summary>
        public Sizes Sizes { get; set; }

        /// <summary>
        /// Applicable media
        /// </summary>
        public Media Media { get; set; }
    }
}
