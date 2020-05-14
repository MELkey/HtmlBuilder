namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Container for document metadata
    /// </summary>
    public class Head : GlobalElement
    {
        private const string name = "head";
        public override string TagName => name;
    }
}
