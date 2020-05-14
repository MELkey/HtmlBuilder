using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Gauge
    /// </summary>
    public class Meter : GlobalElement
    {
        private const string name = "meter";
        public override string TagName => name;

        /// <summary>
        /// Current value of the element
        /// </summary>
        public ValueFloat Value { get; set; }

        /// <summary>
        /// Minimum value
        /// </summary>
        public Min Min { get; set; }

        /// <summary>
        /// Maximum value
        /// </summary>
        public Max Max { get; set; }

        /// <summary>
        /// High limit of low range
        /// </summary>
        public Low Low { get; set; }

        /// <summary>
        /// Low limit of high range
        /// </summary>
        public High High { get; set; }

        /// <summary>
        /// Optimum value in gauge
        /// </summary>
        public Optimum Optimum { get; set; }
    }
}
