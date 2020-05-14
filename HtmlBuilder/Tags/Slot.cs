using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Shadow tree slot
    /// </summary>
    public class Slot : GlobalElement
    {
        private const string name = "slot";
        public override string TagName => name;

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }
    }
}
