namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Generic flow container, or container for name-value groups in dl elements
    /// </summary>
    public class Div : GlobalElement
    {
        private const string name = "div";
        public override string TagName => name;
    }
}
