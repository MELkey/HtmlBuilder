namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Language of the linked resource
    /// </summary>
    public sealed class HRefLang : AttributeBase<string>
    {
        private const string name = "hreflang";

        public override string AttributeName => name;
    }
}
