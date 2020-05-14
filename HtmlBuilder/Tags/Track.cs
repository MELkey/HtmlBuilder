using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Timed text track
    /// </summary>
    public class Track : GlobalElement
    {
        private const string name = "tarck";
        public override string TagName => name;

        /// <summary>
        /// Enable the track if no other text track is more suitable
        /// </summary>
        public Default Default { get; set; }

        /// <summary>
        /// The type of text track
        /// </summary>
        public Kind Kind { get; set; }

        /// <summary>
        /// User-visible label
        /// </summary>
        public Attributes.Label Label { get; set; }

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// Language of the text track
        /// </summary>
        public SrcLang SrcLang { get; set; }
    }
}
