namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Address of the hyperlink
    /// </summary>
    public sealed class HRef : AttributeBase<string>
    {
        private const string name = "href";

        public override string AttributeName => name;
    }
}
