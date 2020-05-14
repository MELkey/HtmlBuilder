using HtmlBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Link metadata
    /// </summary>
    public class Link : GlobalElement
    {
        private const string name = "link";
        public override string TagName => name;

        /// <summary>
        /// Address of the hyperlink
        /// </summary>
        public HRef Href { get; set; }

        /// <summary>
        /// How the element handles crossorigin requests
        /// </summary>
        public CrossOrigin CrossOrigin { get; set; }

        /// <summary>
        /// Relationship between the location in the document containing the hyperlink and the destination resourc
        /// </summary>
        public Rel Rel { get; set; }

        /// <summary>
        /// Potential destination for a preload request (for rel="preload" and rel="modulepreload")
        /// </summary>
        public As As { get; set; }

        /// <summary>
        /// Applicable media
        /// </summary>
        public Media Media { get; set; }

        /// <summary>
        /// Language of the linked resource
        /// </summary>
        public HRefLang HRefLang { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public Attributes.Type Type { get; set; }

        /// <summary>
        /// Image sizes for different page layouts
        /// </summary>
        public Sizes Sizes { get; set; }

        /// <summary>
        /// Images to use in different situations (e.g., high-resolution displays, small monitors, etc.)
        /// </summary>
        public ImageSrcSet ImageSrcSet { get; set; }

        /// <summary>
        /// Image sizes for different page layouts
        /// </summary>
        public ImageSizes ImageSizes { get; set; }

        /// <summary>
        /// Referrer policy for fetches initiated by the element
        /// </summary>
        public ReferrerPolicy ReferrerPolicy { get; set; }

        /// <summary>
        /// Integrity metadata used in Subresource Integrity checks [SRI]
        /// </summary>
        public Integrity Integrity { get; set; }

        /// <summary>
        /// Color to use when customizing a site's icon (for rel="mask-icon")
        /// </summary>
        public Color Color { get; set; }
    }
}
