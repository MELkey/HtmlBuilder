namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Section heading
    /// </summary>
    public class H1 : GlobalElement
    {
        private const string name = "h1";
        public override string TagName => name;
    }
}
