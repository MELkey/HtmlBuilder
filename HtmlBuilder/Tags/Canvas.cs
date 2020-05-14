using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Scriptable bitmap canvas
    /// </summary>
    public class Canvas : GlobalElement
    {
        private const string name = "canvas";
        public override string TagName => name;

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
