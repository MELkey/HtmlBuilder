using HtmlBuilder.Tags;

namespace HtmlBuilder
{
    public interface ITagSet<TParentElement> where TParentElement : IElement
    {
        /// <summary>
        /// Hyperlink
        /// </summary>
        Element<A, TParentElement> A { get; }

        /// <summary>
        /// Abbreviation
        /// </summary>
        Element<Abbr, TParentElement> Abbr { get; }

        /// <summary>
        /// Contact information for a page or article element
        /// </summary>
        Element<Address, TParentElement> Address { get; }

        /// <summary>
        /// Hyperlink or dead area on an image map
        /// </summary>
        Element<Area, TParentElement> Area { get; }

        /// <summary>
        /// Self-contained syndicatable or reusable composition
        /// </summary>
        Element<Article, TParentElement> Article { get; }

        /// <summary>
        /// Sidebar for tangentially related content
        /// </summary>
        Element<Aside, TParentElement> Aside { get; }

        /// <summary>
        /// Audio player
        /// </summary>
        Element<Audio, TParentElement> Audio { get; }

        /// <summary>
        /// Keywords
        /// </summary>
        Element<B, TParentElement> B { get; }

        /// <summary>
        /// Base URL and default target browsing context for hyperlinks and forms
        /// </summary>
        Element<Base, TParentElement> Base { get; }

        /// <summary>
        /// Text directionality isolation
        /// </summary>
        Element<Bdi, TParentElement> Bdi { get; }

        /// <summary>
        /// Text directionality formatting
        /// </summary>
        Element<Bdo, TParentElement> Bdo { get; }

        /// <summary>
        /// A section quoted from another source
        /// </summary>
        Element<BlockQuote, TParentElement> BlockQuote { get; }

        /// <summary>
        /// Document body
        /// </summary>
        Element<Body, TParentElement> Body { get; }

        /// <summary>
        /// Line break, e.g. in poem or postal address
        /// </summary>
        Element<Br, TParentElement> Br { get; }

        /// <summary>
        /// Button control
        /// </summary>
        Element<Button, TParentElement> Button { get; }

        /// <summary>
        /// Scriptable bitmap canvas
        /// </summary>
        Element<Canvas, TParentElement> Canvas { get; }

        /// <summary>
        /// Table caption
        /// </summary>
        Element<Caption, TParentElement> Caption { get; }

        /// <summary>
        /// Title of a work
        /// </summary>
        Element<Cite, TParentElement> Cite { get; }

        /// <summary>
        /// Computer code
        /// </summary>
        Element<Code, TParentElement> Code { get; }

        /// <summary>
        /// Table column
        /// </summary>
        Element<Col, TParentElement> Col { get; }

        /// <summary>
        /// Machine-readable equivalent
        /// </summary>
        Element<Data, TParentElement> ColGroup { get; }

        /// <summary>
        /// Container for options for combo box control
        /// </summary>
        Element<DataList, TParentElement> DataList { get; }

        /// <summary>
        /// Content for corresponding dt element(s)
        /// </summary>
        Element<Dd, TParentElement> Dd { get; }

        /// <summary>
        /// A removal from the document
        /// </summary>
        Element<Del, TParentElement> Del { get; }

        /// <summary>
        /// Disclosure control for hiding details
        /// </summary>
        Element<Details, TParentElement> Details { get; }

        /// <summary>
        /// Defining instance
        /// </summary>
        Element<Dfn, TParentElement> Dfn { get; }

        /// <summary>
        /// Dialog box or window
        /// </summary>
        Element<Dialog, TParentElement> Dialog { get; }

        /// <summary>
        /// Generic flow container, or container for name-value groups in dl elements
        /// </summary>
        Element<Div, TParentElement> Div { get; }

        /// <summary>
        /// Association list consisting of zero or more name-value groups
        /// </summary>
        Element<Dl, TParentElement> Dl { get; }

        /// <summary>
        /// Legend for corresponding dd element(s)
        /// </summary>
        Element<Dt, TParentElement> Dt { get; }

        /// <summary>
        /// Stress emphasis
        /// </summary>
        Element<Em, TParentElement> Em { get; }

        /// <summary>
        /// Plugin
        /// </summary>
        Element<Embed, TParentElement> Embed { get; }

        /// <summary>
        /// Group of form controls
        /// </summary>
        Element<FieldSet, TParentElement> FieldSet { get; }

        /// <summary>
        /// Caption for figure
        /// </summary>
        Element<FigCaption, TParentElement> FigCaption { get; }

        /// <summary>
        /// Figure with optional caption
        /// </summary>
        Element<Figure, TParentElement> Figure { get; }

        /// <summary>
        /// Footer for a page or section
        /// </summary>
        Element<Footer, TParentElement> Footer { get; }

        /// <summary>
        /// User-submittable form
        /// </summary>
        Element<Form, TParentElement> Form { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        Element<H1, TParentElement> H1 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        Element<H2, TParentElement> H2 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        Element<H3, TParentElement> H3 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        Element<H4, TParentElement> H4 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        Element<H5, TParentElement> H5 { get; }

        /// <summary>
        /// Section heading
        /// </summary>
        Element<H6, TParentElement> H6 { get; }

        /// <summary>
        /// Container for document metadata
        /// </summary>
        Element<Head, TParentElement> Head { get; }

        /// <summary>
        /// Introductory or navigational aids for a page or section
        /// </summary>
        Element<Header, TParentElement> Header { get; }

        /// <summary>
        /// Heading group
        /// </summary>
        Element<HGroup, TParentElement> HGroup { get; }

        /// <summary>
        /// Thematic break
        /// </summary>
        Element<Hr, TParentElement> Hr { get; }

        /// <summary>
        /// Root element
        /// </summary>
        Element<Html, TParentElement> Html { get; }

        /// <summary>
        /// Alternate voice
        /// </summary>
        Element<I, TParentElement> I { get; }

        /// <summary>
        /// Nested browsing context
        /// </summary>
        Element<IFrame, TParentElement> IFrame { get; }

        /// <summary>
        /// Image
        /// </summary>
        Element<Img, TParentElement> Img { get; }

        /// <summary>
        /// Form control
        /// </summary>
        Element<Input, TParentElement> Input { get; }

        /// <summary>
        /// An addition to the document
        /// </summary>
        Element<Ins, TParentElement> Ins { get; }

        /// <summary>
        /// User input
        /// </summary>
        Element<Kbd, TParentElement> Kbd { get; }

        /// <summary>
        /// Caption for a form control
        /// </summary>
        Element<Label, TParentElement> Label { get; }

        /// <summary>
        /// Caption for fieldset
        /// </summary>
        Element<Legend, TParentElement> Legend { get; }

        /// <summary>
        /// List item
        /// </summary>
        Element<Li, TParentElement> Li { get; }

        /// <summary>
        /// Link metadata
        /// </summary>
        Element<Link, TParentElement> Link { get; }

        /// <summary>
        /// Container for the dominant contents of the document
        /// </summary>
        Element<Main, TParentElement> Main { get; }

        /// <summary>
        /// Image map
        /// </summary>
        Element<Map, TParentElement> Map { get; }

        /// <summary>
        /// Highlight
        /// </summary>
        Element<Mark, TParentElement> Mark { get; }

        /// <summary>
        /// Menu of commands
        /// </summary>
        Element<Menu, TParentElement> Menu { get; }

        /// <summary>
        /// Text metadata	
        /// </summary>
        Element<Meta, TParentElement> Meta { get; }

        /// <summary>
        /// Gauge
        /// </summary>
        Element<Meter, TParentElement> Meter { get; }

        /// <summary>
        /// Section with navigational links
        /// </summary>
        Element<Nav, TParentElement> Nav { get; }

        /// <summary>
        /// Fallback content for script
        /// </summary>
        Element<NoScript, TParentElement> NoScript { get; }

        /// <summary>
        /// Image, nested browsing context, or plugin
        /// </summary>
        Element<Tags.Object, TParentElement> Object { get; }

        /// <summary>
        /// Ordered list
        /// </summary>
        Element<Ol, TParentElement> Ol { get; }

        /// <summary>
        /// Group of options in a list box
        /// </summary>
        Element<OptGroup, TParentElement> OptGroup { get; }

        /// <summary>
        /// Option in a list box or combo box control
        /// </summary>
        Element<Option, TParentElement> Option { get; }

        /// <summary>
        /// Calculated output value
        /// </summary>
        Element<Output, TParentElement> Output { get; }

        /// <summary>
        /// Paragraph
        /// </summary>
        Element<P, TParentElement> P { get; }

        /// <summary>
        /// Parameter for object
        /// </summary>
        Element<Param, TParentElement> Param { get; }

        /// <summary>
        /// Image
        /// </summary>
        Element<Picture, TParentElement> Picture { get; }

        /// <summary>
        /// Block of preformatted text
        /// </summary>
        Element<Pre, TParentElement> Pre { get; }

        /// <summary>
        /// Progress bar
        /// </summary>
        Element<Progress, TParentElement> Progress { get; }

        /// <summary>
        /// Quotation
        /// </summary>
        Element<Q, TParentElement> Q { get; }

        /// <summary>
        /// Parenthesis for ruby annotation text
        /// </summary>
        Element<Rp, TParentElement> Rp { get; }

        /// <summary>
        /// Ruby annotation(s)
        /// </summary>
        Element<Rt, TParentElement> Rt { get; }

        /// <summary>
        /// Inaccurate text
        /// </summary>
        Element<S, TParentElement> S { get; }

        /// <summary>
        /// Computer output
        /// </summary>
        Element<Samp, TParentElement> Samp { get; }

        /// <summary>
        /// Embedded script
        /// </summary>
        Element<Script, TParentElement> Script { get; }

        /// <summary>
        /// Generic document or application section
        /// </summary>
        Element<Section, TParentElement> Section { get; }

        /// <summary>
        /// List box control
        /// </summary>
        Element<Select, TParentElement> Select { get; }

        /// <summary>
        /// Shadow tree slot
        /// </summary>
        Element<Slot, TParentElement> Slot { get; }

        /// <summary>
        /// Side comment
        /// </summary>
        Element<Small, TParentElement> Small { get; }

        /// <summary>
        /// Image source for img or media source for video or audio
        /// </summary>
        Element<Source, TParentElement> Source { get; }

        /// <summary>
        /// Generic phrasing container
        /// </summary>
        Element<Span, TParentElement> Span { get; }

        /// <summary>
        /// Importance
        /// </summary>
        Element<Strong, TParentElement> Strong { get; }

        /// <summary>
        /// Embedded styling information
        /// </summary>
        Element<Style, TParentElement> Style { get; }

        /// <summary>
        /// Subscript
        /// </summary>
        Element<Sub, TParentElement> Sub { get; }

        /// <summary>
        /// Caption for details
        /// </summary>
        Element<Summary, TParentElement> Summary { get; }

        /// <summary>
        /// Superscript
        /// </summary>
        Element<Sup, TParentElement> Sup { get; }

        /// <summary>
        /// Table
        /// </summary>
        Element<Table, TParentElement> Table { get; }

        /// <summary>
        /// Group of rows in a table
        /// </summary>
        Element<TBody, TParentElement> TBody { get; }

        /// <summary>
        /// Table cell
        /// </summary>
        Element<Td, TParentElement> Td { get; }

        /// <summary>
        /// Template
        /// </summary>
        Element<Template, TParentElement> Template { get; }

        /// <summary>
        /// Multiline text controls
        /// </summary>
        Element<TextArea, TParentElement> TextArea { get; }

        /// <summary>
        /// Group of footer rows in a table
        /// </summary>
        Element<TFoot, TParentElement> TFoot { get; }

        /// <summary>
        /// Table header cell
        /// </summary>
        Element<Th, TParentElement> Th { get; }

        /// <summary>
        /// Group of heading rows in a table
        /// </summary>
        Element<THead, TParentElement> THead { get; }

        /// <summary>
        /// Machine-readable equivalent of date- or time-related data
        /// </summary>
        Element<Time, TParentElement> Time { get; }

        /// <summary>
        /// Document title
        /// </summary>
        Element<Title, TParentElement> Title { get; }

        /// <summary>
        /// Table row
        /// </summary>
        Element<Tr, TParentElement> Tr { get; }

        /// <summary>
        /// Timed text track
        /// </summary>
        Element<Track, TParentElement> Track { get; }

        /// <summary>
        /// Unarticulated annotation
        /// </summary>
        Element<U, TParentElement> U { get; }

        /// <summary>
        /// List
        /// </summary>
        Element<Ul, TParentElement> Ul { get; }

        /// <summary>
        /// Variable
        /// </summary>
        Element<Var, TParentElement> Var { get; }

        /// <summary>
        /// Video player
        /// </summary>
        Element<Video, TParentElement> Video { get; }

        /// <summary>
        /// Line breaking opportunity
        /// </summary>
        Element<Wbr, TParentElement> Wbr { get; }
    }
}