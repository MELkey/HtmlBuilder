using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    public abstract class Any : GlobalElement
    {
        /// <summary>
        /// Alternative label to use for the header cell when referencing the cell in other contexts
        /// </summary>
        public Attributes.Abbr Abbr { get; set; }

        /// <summary>
        /// Hint for expected file type in file upload controls
        /// </summary>
        public Accept Accept { get; set; }

        /// <summary>
        /// Character encodings to use for form submission
        /// </summary>
        public AcceptCharSet AcceptCharSet { get; set; }

        /// <summary>
        /// Character encodings to use for form submission
        /// </summary>
        public Attributes.Action Action { get; set; }

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
        /// Replacement text for use when images are not available
        /// </summary>
        public Alt Alt { get; set; }

        /// <summary>
        /// Potential destination for a preload request (for rel="preload" and rel="modulepreload")
        /// </summary>
        public As As { get; set; }

        /// <summary>
        /// Execute script when available, without blocking while fetching
        /// </summary>
        public Async Async { get; set; }

        // <summary>
        /// Hint for form autofill feature
        /// </summary>
        public AutoComplete AutoComplete { get; set; }

        /// <summary>
        /// Hint that the media resource can be started automatically when the page is loaded
        /// </summary>
        public AutoPlay AutoPlay { get; set; }

        /// <summary>
        /// Character encoding declaration
        /// </summary>
        public CharSet CharSet { get; set; }

        /// <summary>
        /// Whether the control is checked
        /// </summary>
        public Checked Checked { get; set; }

        /// <summary>
        /// Link to the source of the quotation or more information about the edit
        /// </summary>
        public Attributes.Cite Cite { get; set; }

        /// <summary>
        /// Color to use when customizing a site's icon (for rel="mask-icon")
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Maximum number of characters per line
        /// </summary>
        public Cols Cols { get; set; }

        /// <summary>
        /// Number of columns that the cell is to span
        /// </summary>
        public ColSpan ColSpan { get; set; }

        /// <summary>
        /// Value of the element
        /// </summary>
        public Content Content { get; set; }

        /// <summary>
        /// Show user agent controls
        /// </summary>
        public Controls Controls { get; set; }

        /// <summary>
        /// Coordinates for the shape to be created in an image map
        /// </summary>
        public Coords Coords { get; set; }

        /// <summary>
        /// How the element handles crossorigin requests
        /// </summary>
        public CrossOrigin CrossOrigin { get; set; }

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Attributes.Data Data { get; set; }

        /// <summary>
        /// Date and (optionally) time of the change
        /// </summary>
        public Attributes.DateTime DateTime { get; set; }

        /// <summary>
        /// Decoding hint to use when processing this image for presentation
        /// </summary>
        public Decoding Decoding { get; set; }

        /// <summary>
        /// Enable the track if no other text track is more suitable
        /// </summary>
        public Default Default { get; set; }

        /// <summary>
        /// Defer script execution
        /// </summary>
        public Defer Defer { get; set; }

        /// <summary>
        /// The text directionality of the element
        /// </summary>
        public new DirBdo Dir { get; set; }

        /// <summary>
        /// Name of form control to use for sending the element's directionality in form submission
        /// </summary>
        public DirName DirName { get; set; }

        /// <summary>
        /// Whether the form control is disabled
        /// </summary>
        public Disabled Disabled { get; set; }

        /// <summary>
        /// Whether to download the resource instead of navigating to it, and its file name if so
        /// </summary>
        public Download Download { get; set; }

        /// <summary>
        /// Entry list encoding type to use for form submission
        /// </summary>
        public EncType EncType { get; set; }

        /// <summary>
        /// Associate the label with form control
        /// </summary>
        public For For { get; set; }

        /// <summary>
        /// Associates the element with a form element
        /// </summary>
        public Attributes.Form Form { get; set; }

        /// <summary>
        /// URL to use for form submission
        /// </summary>
        public FormAction FormAction { get; set; }

        /// <summary>
        /// Entry list encoding type to use for form submission
        /// </summary>
        public FormEncType FormEncType { get; set; }

        /// <summary>
        /// Variant to use for form submission
        /// </summary>
        public FormMethod FormMethod { get; set; }

        /// <summary>
        /// Bypass form control validation for form submission
        /// </summary>
        public FormNoValidate FormNoValidate { get; set; }

        /// <summary>
        /// Browsing context for form submission
        /// </summary>
        public FormTarget FormTarget { get; set; }

        /// <summary>
        /// The header cells for this cell
        /// </summary>
        public Headers Headers { get; set; }

        /// <summary>
        /// Vertical dimension
        /// </summary>
        public Height Height { get; set; }

        /// <summary>
        /// Low limit of high range
        /// </summary>
        public High High { get; set; }

        /// <summary>
        /// Address of the hyperlink
        /// </summary>
        public HRef HRef { get; set; }

        /// <summary>
        /// Language of the linked resource
        /// </summary>
        public HRefLang HRefLang { get; set; }

        /// <summary>
        /// Pragma directive
        /// </summary>
        public HttpEquiv HttpEquiv { get; set; }

        /// <summary>
        /// Image sizes for different page layouts
        /// </summary>
        public ImageSizes ImageSizes { get; set; }

        /// <summary>
        /// Images to use in different situations (e.g., high-resolution displays, small monitors, etc.)
        /// </summary>
        public ImageSrcSet ImageSrcSet { get; set; }

        /// <summary>
        /// Integrity metadata used in Subresource Integrity checks [SRI]
        /// </summary>
        public Integrity Integrity { get; set; }

        /// <summary>
        /// Whether the image is a server-side image map
        /// </summary>
        public IsMap IsMap { get; set; }

        /// <summary>
        /// The type of text track
        /// </summary>
        public Kind Kind { get; set; }

        /// <summary>
        /// User-visible label
        /// </summary>
        public Attributes.Label Label { get; set; }

        /// <summary>
        /// List of autocomplete options
        /// </summary>
        public List List { get; set; }

        /// <summary>
        /// Whether to loop the media resource
        /// </summary>
        public Loop Loop { get; set; }

        /// <summary>
        /// High limit of low range
        /// </summary>
        public Low Low { get; set; }

        /// <summary>
        /// Application cache manifest
        /// </summary>
        public Manifest Manifest { get; set; }

        /// <summary>
        /// Maximum value
        /// </summary>
        public Max Max { get; set; }

        /// <summary>
        /// Maximum length of value
        /// </summary>
        public MaxLength MaxLength { get; set; }

        /// <summary>
        /// Applicable media
        /// </summary>
        public Media Media { get; set; }

        /// <summary>
        /// Variant to use for form submission
        /// </summary>
        public Method Method { get; set; }

        /// <summary>
        /// Minimum value
        /// </summary>
        public Min Min { get; set; }

        /// <summary>
        /// Minimum length of value
        /// </summary>
        public MinLength MinLength { get; set; }

        /// <summary>
        /// Whether to allow multiple values
        /// </summary>
        public Multiple Multiple { get; set; }

        /// <summary>
        /// Whether to mute the media resource by default
        /// </summary>
        public Muted Muted { get; set; }

        /// <summary>
        /// Name of the element to use for form submission and in the form.elements API
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Prevents execution in user agents that support module scripts
        /// </summary>
        public NoModule NoModule { get; set; }

        /// <summary>
        /// Bypass form control validation for form submission
        /// </summary>
        public NoValidate NoValidate { get; set; }

        /// <summary>
        /// Whether the details are visible
        /// </summary>
        public Open Open { get; set; }

        /// <summary>
        /// Optimum value in gauge
        /// </summary>
        public Optimum Optimum { get; set; }

        /// <summary>
        /// Pattern to be matched by the form control's value
        /// </summary>
        public Pattern Pattern { get; set; }

        /// <summary>
        /// URLs to ping
        /// </summary>
        public Ping Ping { get; set; }

        /// <summary>
        /// User-visible label to be placed within the form control
        /// </summary>
        public PlaceHolder PlaceHolder { get; set; }

        /// <summary>
        /// Encourage the user agent to display video content within the element's playback area
        /// </summary>
        public PlaysInLine PlaysInLine { get; set; }

        /// <summary>
        /// Poster frame to show prior to video playback
        /// </summary>
        public Poster Poster { get; set; }

        /// <summary>
        /// Hints how much buffering the media resource will likely need
        /// </summary>
        public Preload Preload { get; set; }

        /// <summary>
        /// Whether to allow the value to be edited by the user
        /// </summary>
        public ReadOnly ReadOnly { get; set; }

        /// <summary>
        /// Referrer policy for fetches initiated by the element
        /// </summary>
        public ReferrerPolicy ReferrerPolicy { get; set; }

        /// <summary>
        /// Relationship between the location in the document containing the hyperlink and the destination resourc
        /// </summary>
        public Rel Rel { get; set; }

        /// <summary>
        /// Whether the control is required for form submission
        /// </summary>
        public Required Required { get; set; }

        /// <summary>
        /// Number the list backwards
        /// </summary>
        public Reversed Reversed { get; set; }

        /// <summary>
        /// Number of lines to show
        /// </summary>
        public Rows Rows { get; set; }

        /// <summary>
        /// Number of rows that the cell is to span
        /// </summary>
        public RowSpan RowSpan { get; set; }

        /// <summary>
        /// Security rules for nested content
        /// </summary>
        public Sandbox Sandbox { get; set; }

        /// <summary>
        /// Specifies which cells the header cell applies to
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Whether the option is selected by default
        /// </summary>
        public Selected Selected { get; set; }

        /// <summary>
        /// The kind of shape to be created in an image map
        /// </summary>
        public Shape Shape { get; set; }

        /// <summary>
        /// Size of the control
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Image sizes for different page layouts
        /// </summary>
        public Sizes Sizes { get; set; }

        /// <summary>
        /// Number of columns spanned by the element
        /// </summary>
        public Attributes.Span Span { get; set; }

        /// <summary>
        /// Address of the resource
        /// </summary>
        public Src Src { get; set; }

        /// <summary>
        /// A document to render in the iframe
        /// </summary>
        public SrcDoc SrcDoc { get; set; }

        /// <summary>
        /// Language of the text track
        /// </summary>
        public SrcLang SrcLang { get; set; }

        /// <summary>
        /// Images to use in different situations (e.g., high-resolution displays, small monitors, etc.)
        /// </summary>
        public SrcSet SrcSet { get; set; }

        /// <summary>
        /// Starting value of the list
        /// </summary>
        public Start Start { get; set; }

        /// <summary>
        /// Granularity to be matched by the form control's value
        /// </summary>
        public Step Step { get; set; }

        /// <summary>
        /// Browsing context
        /// </summary>
        public Target Target { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public Attributes.Type Type { get; set; }

        /// <summary>
        /// Name of image map to use
        /// </summary>
        public UseMap UseMap { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public Value Value { get; set; }

        /// <summary>
        /// Horizontal dimension
        /// </summary>
        public Width Width { get; set; }

        /// <summary>
        /// How the value of the form control is to be wrapped for form submission
        /// </summary>
        public Wrap Wrap { get; set; }
    }
}
