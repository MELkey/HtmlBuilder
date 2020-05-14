namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Association list consisting of zero or more name-value groups
    /// </summary>
    public class Dl : GlobalElement
    {
        private const string name = "dl";
        public override string TagName => name;
    }
}
