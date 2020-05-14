using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Nested browsing context
    /// </summary>
    public class IFrame : GlobalElement
    {
        private const string name = "iframe";
        public override string TagName => name;

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// A document to render in the iframe
        /// </summary>
        public SrcDoc SrcDoc { get; set; }

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Security rules for nested content
        /// </summary>
        public Sandbox Sandbox { get; set; }

        /// <summary>
        /// Feature policy to be applied to the iframe's contents
        /// </summary>
        public Allow Allow { get; set; }

        /// <summary>
        /// Whether to allow the iframe's contents to use requestFullscreen()
        /// </summary>
        public AllowFullScreen AllowFullScreen { get; set; }

        /// <summary>
        /// Whether the iframe's contents are allowed to use the PaymentRequest interface to make payment requests
        /// </summary>
        public AllowPaymentRequest AllowPaymentRequest { get; set; }

        /// <summary>
        /// Horizontal dimension
        /// </summary>
        public Width Width { get; set; }

        /// <summary>
        /// Vertical dimension
        /// </summary>
        public Height Height { get; set; }

        /// <summary>
        /// Referrer policy for fetches initiated by the element
        /// </summary>
        public ReferrerPolicy ReferrerPolicy { get; set; }
    }
}
