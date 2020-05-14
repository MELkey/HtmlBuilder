using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Calculated output value
    /// </summary>
    public class Output : GlobalElement
    {
        private const string name = "output";
        public override string TagName => name;

        /// <summary>
        /// Associate the label with form control
        /// </summary>
        public For For { get; set; }

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
