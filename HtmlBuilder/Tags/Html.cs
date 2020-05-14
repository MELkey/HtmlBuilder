using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Root element
    /// </summary>
    public class Html : GlobalElement
    {
        private const string name = "html";
        public override string TagName => name;

        /// <summary>
        /// Application cache manifest
        /// </summary>
        public Manifest Manifest { get; set; }
    }
}
