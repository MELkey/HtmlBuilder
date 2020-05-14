using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// User-submittable form
    /// </summary>
    public class Form : GlobalElement
    {
        private const string name = "form";
        public override string TagName => name;

        /// <summary>
        /// Character encodings to use for form submission
        /// </summary>
        public AcceptCharSet AcceptCharSet { get; set; }

        /// <summary>
        /// URL to use for form submission
        /// </summary>
        public Attributes.Action Action { get; set; }

        /// <summary>
        /// Default setting for autofill feature for controls in the form
        /// </summary>
        public AutoCompleteForm AutoComplete { get; set; }

        // <summary>
        /// Entry list encoding type to use for form submission
        /// </summary>
        public EncType EncType { get; set; }

        /// <summary>
        /// Variant to use for form submission
        /// </summary>
        public Method Method { get; set; }

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Bypass form control validation for form submission
        /// </summary>
        public NoValidate NoValidate { get; set; }

        /// <summary>
        /// Browsing context
        /// </summary>
        public Target Target { get; set; }
    }
}
