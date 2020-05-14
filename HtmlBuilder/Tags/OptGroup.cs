using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Group of options in a list box
    /// </summary>
    public class OptGroup : GlobalElement
    {
        private const string name = "optgroup";
        public override string TagName => name;

        /// <summary>
        /// Whether the form control is disabled
        /// </summary>
        public Disabled Disabled { get; set; }

        /// <summary>
        /// User-visible label
        /// </summary>
        public Attributes.Label Label { get; set; }
    }
}
