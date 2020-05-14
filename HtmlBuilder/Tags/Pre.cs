namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Block of preformatted text
    /// </summary>
    public class Pre : GlobalElement
    {
        private const string name = "pre";
        public override string TagName => name;
    }
}
