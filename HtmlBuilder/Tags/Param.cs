using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Parameter for object
    /// </summary>
    public class Param : GlobalElement
    {
        private const string name = "param";
        public override string TagName => name;

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public Value Value { get; set; }
    }
}
