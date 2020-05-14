namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Machine-readable equivalent of date- or time-related data
    /// </summary>
    public class Time : GlobalElement
    {
        private const string name = "time";
        public override string TagName => name;

        /// <summary>
        /// Date and (optionally) time of the change
        /// </summary>
        public Attributes.DateTime DateTime { get; set; }
    }
}
