using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Button control
    /// </summary>
    public class Button : GlobalElement
    {
        private const string name = "button";
        public override string TagName => name;

        /// <summary>
        /// Whether the form control is disabled
        /// </summary>
        public Disabled Disabled { get; set; }

        /// <summary>
        /// Associates the element with a form element
        /// </summary>
        public Attributes.Form Form { get; set; }

        /// <summary>
        /// URL to use for form submission
        /// </summary>
        public FormAction FormAction { get; set; }

        /// <summary>
        /// Entry list encoding type to use for form submission
        /// </summary>
        public FormEncType FormEncType { get; set; }

        /// <summary>
        /// Variant to use for form submission
        /// </summary>
        public FormMethod FormMethod { get; set; }

        /// <summary>
        /// Bypass form control validation for form submission
        /// </summary>
        public FormNoValidate FormNoValidate { get; set; }

        /// <summary>
        /// Browsing context for form submission
        /// </summary>
        public FormTarget FormTarget { get; set; }

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Type of button	
        /// </summary>
        public TypeButton Type { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public Value Value { get; set; }
    }
}
