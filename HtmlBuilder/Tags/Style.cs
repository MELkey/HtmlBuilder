using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Embedded styling information
    /// </summary>
    public class Style : GlobalElement
    {
        private const string name = "style";
        public override string TagName => name;

        /// <summary>
        /// Applicable media
        /// </summary>
        public Media Media { get; set; }
    }
}
