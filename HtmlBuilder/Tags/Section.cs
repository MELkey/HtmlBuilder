namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Generic document or application section
    /// </summary>
    public class Section : GlobalElement
    {
        private const string name = "section";
        public override string TagName => name;
    }
}
