using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Plugin
    /// </summary>
    public class Embed : GlobalElement
    {
        private const string name = "embed";
        public override string TagName => name;

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Attributes.Type Type { get; set; }

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
