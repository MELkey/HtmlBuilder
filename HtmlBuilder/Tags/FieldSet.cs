using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Group of form controls
    /// </summary>
    public class FieldSet : GlobalElement
    {
        private const string name = "fieldset";
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
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }
    }
}
