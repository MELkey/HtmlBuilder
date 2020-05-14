using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Caption for a form control
    /// </summary>
    public class Label : GlobalElement
    {
        private const string name = "label";
        public override string TagName => name;

        /// <summary>
        /// Associate the label with form control
        /// </summary>
        public For For { get; set; }
    }
}
