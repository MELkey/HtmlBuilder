using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Dialog box or window
    /// </summary>
    public class Dialog : GlobalElement
    {
        private const string name = "dialog";
        public override string TagName => name;

        /// <summary>
        /// Whether the details are visible
        /// </summary>
        public Open Open { get; set; }
    }
}
