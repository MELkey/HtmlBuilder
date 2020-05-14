using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Form control
    /// </summary>
    public class Input : GlobalElement
    {
        private const string name = "input";
        public override string TagName => name;

        /// <summary>
        /// Hint for expected file type in file upload controls
        /// </summary>
        public Accept Accept { get; set; }

        /// <summary>
        /// Replacement text for use when images are not available
        /// </summary>
        public Alt Alt { get; set; }

        /// <summary>
        /// Hint for form autofill feature
        /// </summary>
        public AutoComplete AutoComplete { get; set; }

        /// <summary>
        /// Whether the control is checked
        /// </summary>
        public Checked Checked { get; set; }

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
        /// Vertical dimension
        /// </summary>
        public Height Height { get; set; }

        /// <summary>
        /// List of autocomplete options
        /// </summary>
        public List List { get; set; }

        /// <summary>
        /// Maximum value
        /// </summary>
        public Max Max { get; set; }

        /// <summary>
        /// Maximum length of value
        /// </summary>
        public MaxLength MaxLength { get; set; }

        /// <summary>
        /// Minimum value
        /// </summary>
        public Min Min { get; set; }

        /// <summary>
        /// Minimum length of value
        /// </summary>
        public MinLength MinLength { get; set; }

        /// <summary>
        /// Whether to allow multiple values
        /// </summary>
        public Multiple Multiple { get; set; }

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Pattern to be matched by the form control's value
        /// </summary>
        public Pattern Pattern { get; set; }

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

        /// <summary>
        /// Size of the control
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// Granularity to be matched by the form control's value
        /// </summary>
        public Step Step { get; set; }

        /// <summary>
        /// Type of form control
        /// </summary>
        public TypeInput Type { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public Value Value { get; set; }

        /// <summary>
        /// Horizontal dimension
        /// </summary>
        public Width Width { get; set; }
    }
}
