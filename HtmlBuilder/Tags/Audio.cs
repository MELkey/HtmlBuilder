using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Audio player
    /// </summary>
    public class Audio : GlobalElement
    {
        private const string name = "audio";
        public override string TagName => name;

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// How the element handles crossorigin requests
        /// </summary>
        public CrossOrigin CrossOrigin { get; set; }

        /// <summary>
        /// Hints how much buffering the media resource will likely need
        /// </summary>
        public Preload Preload { get; set; }

        /// <summary>
        /// Hint that the media resource can be started automatically when the page is loaded
        /// </summary>
        public AutoPlay AutoPlay { get; set; }

        /// <summary>
        /// Whether to loop the media resource
        /// </summary>
        public Loop Loop { get; set; }

        /// <summary>
        /// Whether to mute the media resource by default
        /// </summary>
        public Muted Muted { get; set; }

        /// <summary>
        /// Show user agent controls
        /// </summary>
        public Controls Controls { get; set; }
    }
}
