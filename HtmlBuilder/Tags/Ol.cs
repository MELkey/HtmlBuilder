using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Ordered list
    /// </summary>
    public class Ol : GlobalElement
    {
        private const string name = "ol";
        public override string TagName => name;

        /// <summary>
        /// Number the list backwards
        /// </summary>
        public Reversed Reversed { get; set; }

        /// <summary>
        /// Starting value of the list
        /// </summary>
        public Start Start { get; set; }

        /// <summary>
        /// Kind of list marker
        /// </summary>
        public TypeOl Type { get; set; }
    }
}
