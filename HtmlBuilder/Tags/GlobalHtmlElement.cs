using HtmlBuilder.Attributes;

namespace HtmlBuilder.Tags
{
    public abstract class GlobalElement
    {
        public abstract string TagName { get; }

        /// <summary>
        /// Keyboard shortcut to activate or focus element
        /// </summary>
        public AccessKey AccessKey { get; set; }

        /// <summary>
        /// Recommended autocapitalization behavior (for supported input methods)
        /// </summary>
        public AutoCapitalize AutoCapitalize { get; set; }

        /// <summary>
        /// Automatically focus the element when the page is loaded
        /// </summary>
        public AutoFocus AutoFocus { get; set; }

        /// <summary>
        /// Classes to which the element belongs
        /// </summary>
        public Class Class { get; set; }

        /// <summary>
        /// Whether the element is editable
        /// </summary>
        public ContentEditable ContentEditable { get; set; }

        /// <summary>
        /// The text directionality of the element
        /// </summary>
        public Dir Dir { get; set; }

        /// <summary>
        /// Whether the element is draggable
        /// </summary>
        public Draggable Draggable { get; set; }

        /// <summary>
        /// Hint for selecting an enter key action
        /// </summary>
        public EnterKeyHint EnterKeyHint { get; set; }

        /// <summary>
        /// Whether the element is relevant
        /// </summary>
        public Hidden Hidden { get; set; }

        /// <summary>
        /// The element's ID
        /// </summary>
        public Id Id { get; set; }

        /// <summary>
        /// Hint for selecting an input modality
        /// </summary>
        public InputMode InputMode { get; set; }

        /// <summary>
        /// Creates a customized built-in element
        /// </summary>
        public Is Is { get; set; }

        /// <summary>
        /// Global identifier for a microdata item
        /// </summary>
        public ItemId ItemId { get; set; }

        /// <summary>
        /// Property names of a microdata item
        /// </summary>
        public ItemProp ItemProp { get; set; }

        /// <summary>
        /// Referenced elements
        /// </summary>
        public ItemRef ItemRef { get; set; }

        /// <summary>
        /// Introduces a microdata item
        /// </summary>
        public ItemScope ItemScope { get; set; }

        /// <summary>
        /// Item types of a microdata item
        /// </summary>
        public ItemType ItemType { get; set; }

        /// <summary>
        /// Language of the element
        /// </summary>
        public Lang Lang { get; set; }

        /// <summary>
        /// Cryptographic nonce used in Content Security Policy checks [CSP]
        /// </summary>
        public Nonce Nonce { get; set; }

        /// <summary>
        /// The element's desired slot
        /// </summary>
        public Attributes.Slot Slot { get; set; }

        /// <summary>
        /// Whether the element is to have its spelling and grammar checked
        /// </summary>
        public SpellCheck SpellCheck { get; set; }

        /// <summary>
        /// Presentational and formatting instructions
        /// </summary>
        public Attributes.Style Style { get; set; }

        /// <summary>
        /// Whether the element is focusable and sequentially focusable, 
        /// and the relative order of the element for the purposes of 
        /// sequential focus navigation
        /// </summary>
        public TabIndex TabIndex { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public Attributes.Title Title { get; set; }

        /// <summary>
        /// Whether the element is to be translated when the page is localized
        /// </summary>
        public Translate Translate { get; set; }
        
    }
}
