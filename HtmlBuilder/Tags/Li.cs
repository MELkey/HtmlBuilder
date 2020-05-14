using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// List item
    /// </summary>
    public class Li : GlobalElement
    {
        private const string name = "li";
        public override string TagName => name;

        /// <summary>
        /// Ordinal value of the list item
        /// </summary>
        public ValueLi Value { get; set; }
    }
}
