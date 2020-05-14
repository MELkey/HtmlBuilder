namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Language of the text track
    /// </summary>
    public sealed class SrcLang : AttributeBase<string>
    {
        private const string name = "srclang";

        public override string AttributeName => name;
    }
}
