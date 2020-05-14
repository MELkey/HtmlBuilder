using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Image, nested browsing context, or plugin
    /// </summary>
    public class Object : GlobalElement
    {
        private const string name = "object";
        public override string TagName => name;

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Attributes.Data Data { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public Attributes.Type Type { get; set; }

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Name of image map to use
        /// </summary>
        public UseMap UseMap { get; set; }

        /// <summary>
        /// Associates the element with a form element
        /// </summary>
        public Attributes.Form Form { get; set; }

        /// <summary>
        /// Horizontal dimension
        /// </summary>
        public Width Width { get; set; }

        /// <summary>
        /// Vertical dimension
        /// </summary>
        public Height Height { get; set; }
    }
}
