namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Relationship between the location in the document containing the hyperlink and the destination resourc
    /// </summary>
    public sealed class Rel : AttributeBase<string>
    {
        private const string name = "rel";

        public override string AttributeName => name;
    }
}
