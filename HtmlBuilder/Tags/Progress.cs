using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Progress bar
    /// </summary>
    public class Progress : GlobalElement
    {
        private const string name = "progress";
        public override string TagName => name;

        /// <summary>
        /// Current value of the element
        /// </summary>
        public ValueFloat Value { get; set; }

        /// <summary>
        /// Maximum value
        /// </summary>
        public Max Max { get; set; }
    }
}
