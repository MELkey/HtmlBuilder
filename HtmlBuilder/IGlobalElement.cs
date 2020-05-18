using HtmlBuilder.Attributes;

namespace HtmlBuilder
{
    public interface IGlobalElement
    {
        AccessKey AccessKey { get; set; }
        AutoCapitalize AutoCapitalize { get; set; }
        AutoFocus AutoFocus { get; set; }
        Class Class { get; set; }
        ContentEditable ContentEditable { get; set; }
        Dir Dir { get; set; }
        Draggable Draggable { get; set; }
        EnterKeyHint EnterKeyHint { get; set; }
        Hidden Hidden { get; set; }
        Id Id { get; set; }
        InputMode InputMode { get; set; }
        Is Is { get; set; }
        ItemId ItemId { get; set; }
        ItemProp ItemProp { get; set; }
        ItemRef ItemRef { get; set; }
        ItemScope ItemScope { get; set; }
        ItemType ItemType { get; set; }
        Lang Lang { get; set; }
        Nonce Nonce { get; set; }
        Attributes.Slot Slot { get; set; }
        SpellCheck SpellCheck { get; set; }
        Attributes.Style Style { get; set; }
        TabIndex TabIndex { get; set; }
        string TagName { get; }
        Attributes.Title Title { get; set; }
        Translate Translate { get; set; }
    }
}