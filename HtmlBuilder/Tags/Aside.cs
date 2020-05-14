namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Sidebar for tangentially related content
    /// </summary>
    public class Aside : GlobalElement
    {
        private const string name = "aside";
        public override string TagName => name;
    }
}
