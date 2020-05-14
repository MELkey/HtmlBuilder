using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Image map
    /// </summary>
    public class Map : GlobalElement
    {
        private const string name = "map";
        public override string TagName => name;

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }
    }
}
