using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Disclosure control for hiding details
    /// </summary>
    public class Details : GlobalElement
    {
        private const string name = "details";
        public override string TagName => name;

        /// <summary>
        /// Whether the details are visible
        /// </summary>
        public Open Open { get; set; }
    }
}
