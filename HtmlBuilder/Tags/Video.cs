using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Video player
    /// </summary>
    public class Video : GlobalElement
    {
        private const string name = "video";
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
        /// Poster frame to show prior to video playback
        /// </summary>
        public Poster Poster { get; set; }

        /// <summary>
        /// Hints how much buffering the media resource will likely need
        /// </summary>
        public Preload Preload { get; set; }

        /// <summary>
        /// Hint that the media resource can be started automatically when the page is loaded
        /// </summary>
        public AutoPlay AutoPlay { get; set; }

        /// <summary>
        /// Encourage the user agent to display video content within the element's playback area
        /// </summary>
        public PlaysInLine PlaysInLine { get; set; }

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

        /// <summary>
        /// Horizontal dimension
        /// </summary>
        public Width Width { get; set; }

        /// <summary>
        /// Vertical dimension
        /// </summary>
        public Height Height { get; set; }
    }
}
