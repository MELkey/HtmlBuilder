using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Machine-readable equivalent
    /// </summary>
    public class Data : GlobalElement
    {
        private const string name = "data";
        public override string TagName => name;

        /// <summary>
        /// Value
        /// </summary>
        public Value Value { get; set; }
    }
}
