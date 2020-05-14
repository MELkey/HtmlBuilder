namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Fallback content for script
    /// </summary>
    public class NoScript : GlobalElement
    {
        private const string name = "noscript";
        public override string TagName => name;
    }
}
