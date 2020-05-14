namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Self-contained syndicatable or reusable composition
    /// </summary>
    public class Article : GlobalElement
    {
        private const string name = "article";
        public override string TagName => name;
    }
}
