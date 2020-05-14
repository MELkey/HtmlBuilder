using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Embedded script
    /// </summary>
    public class Script : GlobalElement
    {
        private const string name = "script";
        public override string TagName => name;

        // <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public Attributes.Type Type { get; set; }

        /// <summary>
        /// Execute script when available, without blocking while fetching
        /// </summary>
        public Async Async { get; set; }

        /// <summary>
        /// Defer script execution
        /// </summary>
        public Defer Defer { get; set; }

        /// <summary>
        /// How the element handles crossorigin requests
        /// </summary>
        public CrossOrigin CrossOrigin { get; set; }

        /// <summary>
        /// Integrity metadata used in Subresource Integrity checks [SRI]
        /// </summary>
        public Integrity Integrity { get; set; }

        /// <summary>
        /// Referrer policy for fetches initiated by the element
        /// </summary>
        public ReferrerPolicy ReferrerPolicy { get; set; }
    }
}
