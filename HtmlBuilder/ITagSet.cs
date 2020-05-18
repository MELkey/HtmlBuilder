using HtmlBuilder.Tags;

namespace HtmlBuilder
{
    public interface ITagSet<TParentElement> where TParentElement : IElement
    {
        /// <summary>
        /// Hyperlink
        /// </summary>
        IElement<A, TParentElement> A { get; }

        /// <summary>
        /// Abbreviation
        /// </summary>
        IElement<Abbr, TParentElement> Abbr { get; }

        /// <summary>
        /// Contact information for a page or article element
        /// </summary>
        IElement<Address, TParentElement> Address { get; }

        /// <summary>
        /// Hyperlink or dead area on an image map
        /// </summary>
        IElement<Area, TParentElement> Area { get; }

        /// <summary>
        /// Self-contained syndicatable or reusable composition
        /// </summary>
        IElement<Article, TParentElement> Article { get; }

        /// <summary>
        /// Sidebar for tangentially related content
        /// </summary>
        IElement<Aside, TParentElement> Aside { get; }

        /// <summary>
        /// Audio player
        /// </summary>
        IElement<Audio, TParentElement> Audio { get; }

        /// <summary>
        /// Keywords
        /// </summary>
        IElement<B, TParentElement> B { get; }

        /// <summary>
        /// Base URL and default target browsing context for hyperlinks and forms
        /// </summary>
        IElement<Base, TParentElement> Base { get; }

        /// <summary>
        /// Text directionality isolation
        /// </summary>
        IElement<Bdi, TParentElement> Bdi { get; }

        /// <summary>
        /// Text directionality formatting
        /// </summary>
        IElement<Bdo, TParentElement> Bdo { get; }

        /// <summary>
        /// A section quoted from another source
        /// </summary>
        IElement<BlockQuote, TParentElement> BlockQuote { get; }

        /// <summary>
        /// Document body
        /// </summary>
        IElement<Body, TParentElement> Body { get; }

        /// <summary>
        /// Line break, e.g. in poem or postal address
        /// </summary>
        IElement<Br, TParentElement> Br { get; }

        /// <summary>
        /// Button control
        /// </summary>
        IElement<Button, TParentElement> Button { get; }

        /// <summary>
        /// Scriptable bitmap canvas
        /// </summary>
        IElement<Canvas, TParentElement> Canvas { get; }

        /// <summary>
        /// Table caption
        /// </summary>
        IElement<Caption, TParentElement> Caption { get; }

        /// <summary>
        /// Title of a work
        /// </summary>
        IElement<Cite, TParentElement> Cite { get; }

        /// <summary>
        /// Computer code
        /// </summary>
        IElement<Code, TParentElement> Code { get; }

        /// <summary>
        /// Table column
        /// </summary>
        IElement<Col, TParentElement> Col { get; }

        /// <summary>
        /// Machine-readable equivalent
        /// </summary>
        IElement<Data, TParentElement> ColGroup { get; }

        /// <summary>
        /// Container for options for combo box control
        /// </summary>
        IElement<DataList, TParentElement> DataList { get; }

        /// <summary>
        /// Content for corresponding dt element(s)
        /// </summary>
        IElement<Dd, TParentElement> Dd { get; }

        /// <summary>
        /// A removal from the document
        /// </summary>
        IElement<Del, TParentElement> Del { get; }

        /// <summary>
        /// Disclosure control for hiding details
        /// </summary>
        IElement<Details, TParentElement> Details { get; }

        /// <summary>
        /// Defining instance
        /// </summary>
        IElement<Dfn, TParentElement> Dfn { get; }

        /// <summary>
        /// Dialog box or window
        /// </summary>
        IElement<Dialog, TParentElement> Dialog { get; }

        /// <summary>
        /// Generic flow container, or container for name-value groups in dl elements
        /// </summary>
        IElement<Div, TParentElement> Div { get; }

        /// <summary>
        /// Association list consisting of zero or more name-value groups
        /// </summary>
        IElement<Dl, TParentElement> Dl { get; }

        /// <summary>
        /// Legend for corresponding dd element(s)
        /// </summary>
        IElement<Dt, TParentElement> Dt { get; }

        /// <summary>
        /// Stress emphasis
        /// </summary>
        IElement<Em, TParentElement> Em { get; }

        /// <summary>
        /// Plugin
        /// </summary>
        IElement<Embed, TParentElement> Embed { get; }

        /// <summary>
        /// Group of form controls
        /// </summary>
        IElement<FieldSet, TParentElement> FieldSet { get; }

        /// <summary>
        /// Caption for figure
        /// </summary>
        IElement<FigCaption, TParentElement> FigCaption { get; }

        /// <summary>
        /// Figure with optional caption
        /// </summary>
        IElement<Figure, TParentElement> Figure { get; }

        /// <summary>
        /// Footer for a page or section
        /// </summary>
        IElement<Footer, TParentElement> Footer { get; }

        /// <summary>
        /// User-submittable form
        /// </summary>
        IElement<Form, TParentElement> Form { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        IElement<H1, TParentElement> H1 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        IElement<H2, TParentElement> H2 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        IElement<H3, TParentElement> H3 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        IElement<H4, TParentElement> H4 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        IElement<H5, TParentElement> H5 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        IElement<H6, TParentElement> H6 { get; }

        /// <summary>
        /// Container for document metadata
        /// </summary>
        IElement<Head, TParentElement> Head { get; }

        /// <summary>
        /// Introductory or navigational aids for a page or section
        /// </summary>
        IElement<Header, TParentElement> Header { get; }

        /// <summary>
        /// Heading group
        /// </summary>
        IElement<HGroup, TParentElement> HGroup { get; }

        /// <summary>
        /// Thematic break
        /// </summary>
        IElement<Hr, TParentElement> Hr { get; }

        /// <summary>
        /// Root element
        /// </summary>
        IElement<Html, TParentElement> Html { get; }

        /// <summary>
        /// Alternate voice
        /// </summary>
        IElement<I, TParentElement> I { get; }

        /// <summary>
        /// Nested browsing context
        /// </summary>
        IElement<IFrame, TParentElement> IFrame { get; }

        /// <summary>
        /// Image
        /// </summary>
        IElement<Img, TParentElement> Img { get; }

        /// <summary>
        /// Form control
        /// </summary>
        IElement<Input, TParentElement> Input { get; }

        /// <summary>
        /// An addition to the document
        /// </summary>
        IElement<Ins, TParentElement> Ins { get; }

        /// <summary>
        /// User input
        /// </summary>
        IElement<Kbd, TParentElement> Kbd { get; }

        /// <summary>
        /// Caption for a form control
        /// </summary>
        IElement<Label, TParentElement> Label { get; }

        /// <summary>
        /// Caption for fieldset
        /// </summary>
        IElement<Legend, TParentElement> Legend { get; }

        /// <summary>
        /// List item
        /// </summary>
        IElement<Li, TParentElement> Li { get; }

        /// <summary>
        /// Link metadata
        /// </summary>
        IElement<Link, TParentElement> Link { get; }

        /// <summary>
        /// Container for the dominant contents of the document
        /// </summary>
        IElement<Main, TParentElement> Main { get; }

        /// <summary>
        /// Image map
        /// </summary>
        IElement<Map, TParentElement> Map { get; }

        /// <summary>
        /// Highlight
        /// </summary>
        IElement<Mark, TParentElement> Mark { get; }

        /// <summary>
        /// Menu of commands
        /// </summary>
        IElement<Menu, TParentElement> Menu { get; }

        /// <summary>
        /// Text metadata	
        /// </summary>
        IElement<Meta, TParentElement> Meta { get; }

        /// <summary>
        /// Gauge
        /// </summary>
        IElement<Meter, TParentElement> Meter { get; }

        /// <summary>
        /// Section with navigational links
        /// </summary>
        IElement<Nav, TParentElement> Nav { get; }

        /// <summary>
        /// Fallback content for script
        /// </summary>
        IElement<NoScript, TParentElement> NoScript { get; }

        /// <summary>
        /// Image, nested browsing context, or plugin
        /// </summary>
        IElement<Tags.Object, TParentElement> Object { get; }

        /// <summary>
        /// Ordered list
        /// </summary>
        IElement<Ol, TParentElement> Ol { get; }

        /// <summary>
        /// Group of options in a list box
        /// </summary>
        IElement<OptGroup, TParentElement> OptGroup { get; }

        /// <summary>
        /// Option in a list box or combo box control
        /// </summary>
        IElement<Option, TParentElement> Option { get; }

        /// <summary>
        /// Calculated output value
        /// </summary>
        IElement<Output, TParentElement> Output { get; }

        /// <summary>
        /// Paragraph
        /// </summary>
        IElement<P, TParentElement> P { get; }

        /// <summary>
        /// Parameter for object
        /// </summary>
        IElement<Param, TParentElement> Param { get; }

        /// <summary>
        /// Image
        /// </summary>
        IElement<Picture, TParentElement> Picture { get; }

        /// <summary>
        /// Block of preformatted text
        /// </summary>
        IElement<Pre, TParentElement> Pre { get; }

        /// <summary>
        /// Progress bar
        /// </summary>
        IElement<Progress, TParentElement> Progress { get; }

        /// <summary>
        /// Quotation
        /// </summary>
        IElement<Q, TParentElement> Q { get; }

        /// <summary>
        /// Parenthesis for ruby annotation text
        /// </summary>
        IElement<Rp, TParentElement> Rp { get; }

        /// <summary>
        /// Ruby annotation(s)
        /// </summary>
        IElement<Rt, TParentElement> Rt { get; }

        /// <summary>
        /// Inaccurate text
        /// </summary>
        IElement<S, TParentElement> S { get; }

        /// <summary>
        /// Computer output
        /// </summary>
        IElement<Samp, TParentElement> Samp { get; }

        /// <summary>
        /// Embedded script
        /// </summary>
        IElement<Script, TParentElement> Script { get; }

        /// <summary>
        /// Generic document or application section
        /// </summary>
        IElement<Section, TParentElement> Section { get; }

        /// <summary>
        /// List box control
        /// </summary>
        IElement<Select, TParentElement> Select { get; }

        /// <summary>
        /// Shadow tree slot
        /// </summary>
        IElement<Slot, TParentElement> Slot { get; }

        /// <summary>
        /// Side comment
        /// </summary>
        IElement<Small, TParentElement> Small { get; }

        /// <summary>
        /// Image source for img or media source for video or audio
        /// </summary>
        IElement<Source, TParentElement> Source { get; }

        /// <summary>
        /// Generic phrasing container
        /// </summary>
        IElement<Span, TParentElement> Span { get; }

        /// <summary>
        /// Importance
        /// </summary>
        IElement<Strong, TParentElement> Strong { get; }

        /// <summary>
        /// Embedded styling information
        /// </summary>
        IElement<Style, TParentElement> Style { get; }

        /// <summary>
        /// Subscript
        /// </summary>
        IElement<Sub, TParentElement> Sub { get; }

        /// <summary>
        /// Caption for details
        /// </summary>
        IElement<Summary, TParentElement> Summary { get; }

        /// <summary>
        /// Superscript
        /// </summary>
        IElement<Sup, TParentElement> Sup { get; }

        /// <summary>
        /// Table
        /// </summary>
        IElement<Table, TParentElement> Table { get; }

        /// <summary>
        /// Group of rows in a table
        /// </summary>
        IElement<TBody, TParentElement> TBody { get; }

        /// <summary>
        /// Table cell
        /// </summary>
        IElement<Td, TParentElement> Td { get; }

        /// <summary>
        /// Template
        /// </summary>
        IElement<Template, TParentElement> Template { get; }

        /// <summary>
        /// Multiline text controls
        /// </summary>
        IElement<TextArea, TParentElement> TextArea { get; }

        /// <summary>
        /// Group of footer rows in a table
        /// </summary>
        IElement<TFoot, TParentElement> TFoot { get; }

        /// <summary>
        /// Table header cell
        /// </summary>
        IElement<Th, TParentElement> Th { get; }

        /// <summary>
        /// Group of heading rows in a table
        /// </summary>
        IElement<THead, TParentElement> THead { get; }

        /// <summary>
        /// Machine-readable equivalent of date- or time-related data
        /// </summary>
        IElement<Time, TParentElement> Time { get; }

        /// <summary>
        /// Document title
        /// </summary>
        IElement<Title, TParentElement> Title { get; }

        /// <summary>
        /// Table row
        /// </summary>
        IElement<Tr, TParentElement> Tr { get; }

        /// <summary>
        /// Timed text track
        /// </summary>
        IElement<Track, TParentElement> Track { get; }

        /// <summary>
        /// Unarticulated annotation
        /// </summary>
        IElement<U, TParentElement> U { get; }

        /// <summary>
        /// List
        /// </summary>
        IElement<Ul, TParentElement> Ul { get; }

        /// <summary>
        /// Variable
        /// </summary>
        IElement<Var, TParentElement> Var { get; }

        /// <summary>
        /// Video player
        /// </summary>
        IElement<Video, TParentElement> Video { get; }

        /// <summary>
        /// Line breaking opportunity
        /// </summary>
        IElement<Wbr, TParentElement> Wbr { get; }
    }
}