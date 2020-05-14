namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Document title
    /// </summary>
    public class Title : GlobalElement
    {
        private const string name = "title";
        public override string TagName => name;
    }
}
