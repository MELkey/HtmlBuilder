using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Option in a list box or combo box control
    /// </summary>
    public class Option : GlobalElement
    {
        private const string name = "option";
        public override string TagName => name;

        /// <summary>
        /// Whether the form control is disabled
        /// </summary>
        public Disabled Disabled { get; set; }

        /// <summary>
        /// User-visible label
        /// </summary>
        public Attributes.Label Label { get; set; }

        /// <summary>
        /// Whether the option is selected by default
        /// </summary>
        public Selected Selected { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public Value Value { get; set; }
    }
}
