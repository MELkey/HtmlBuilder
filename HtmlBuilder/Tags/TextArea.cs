using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Multiline text controls
    /// </summary>
    public class TextArea : GlobalElement
    {
        private const string name = "textarea";
        public override string TagName => name;

        /// <summary>
        /// Maximum number of characters per line
        /// </summary>
        public Cols Cols { get; set; }

        /// <summary>
        /// Name of form control to use for sending the element's directionality in form submission
        /// </summary>
        public DirName DirName { get; set; }

        /// <summary>
        /// Whether the form control is disabled
        /// </summary>
        public Disabled Disabled { get; set; }

        /// <summary>
        /// Associates the element with a form element
        /// </summary>
        public Attributes.Form Form { get; set; }

        /// <summary>
        /// Maximum length of value
        /// </summary>
        public MaxLength MaxLength { get; set; }

        /// <summary>
        /// Minimum length of value
        /// </summary>
        public MinLength MinLength { get; set; }

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// User-visible label to be placed within the form control
        /// </summary>
        public PlaceHolder PlaceHolder { get; set; }

        /// <summary>
        /// Whether to allow the value to be edited by the user
        /// </summary>
        public ReadOnly ReadOnly { get; set; }

        /// <summary>
        /// Whether the control is required for form submission
        /// </summary>
        public Required Required { get; set; }

        /// Number of lines to show
        /// </summary>
        public Rows Rows { get; set; }

        /// <summary>
        /// How the value of the form control is to be wrapped for form submission
        /// </summary>
        public Wrap Wrap { get; set; }

        /// <summary>
        /// Hint for form autofill feature
        /// </summary>
        public AutoComplete AutoComplete { get; set; }
    }
}
