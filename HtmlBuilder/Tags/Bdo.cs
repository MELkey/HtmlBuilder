using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Text directionality formatting
    /// </summary>
    public class Bdo : GlobalElement
    {
        private const string name = "bdo";
        public override string TagName => name;

        /// <summary>
        /// The text directionality of the element
        /// </summary>
        public new DirBdo Dir { get; set; }
    }
}
