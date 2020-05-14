using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// List box control
    /// </summary>
    public class Select : GlobalElement
    {
        private const string name = "select";
        public override string TagName => name;

        /// <summary>
        /// Hint for form autofill feature
        /// </summary>
        public AutoComplete AutoComplete { get; set; }

        /// <summary>
        /// Whether the form control is disabled
        /// </summary>
        public Disabled Disabled { get; set; }

        /// <summary>
        /// Associates the element with a form element
        /// </summary>
        public Attributes.Form Form { get; set; }

        /// <summary>
        /// Whether to allow multiple values
        /// </summary>
        public Multiple Multiple { get; set; }

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Whether the control is required for form submission
        /// </summary>
        public Required Required { get; set; }

        /// <summary>
        /// Size of the control
        /// </summary>
        public Size Size { get; set; }
    }
}
