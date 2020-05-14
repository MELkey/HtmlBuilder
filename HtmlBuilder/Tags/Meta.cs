using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Text metadata	
    /// </summary>
    public class Meta : GlobalElement
    {
        private const string name = "meta";
        public override string TagName => name;

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Pragma directive
        /// </summary>
        public HttpEquiv HttpEquiv { get; set; }

        /// <summary>
        /// Value of the element
        /// </summary>
        public Content Content { get; set; }

        /// <summary>
        /// Character encoding declaration
        /// </summary>
        public CharSet CharSet { get; set; }
    }
}
