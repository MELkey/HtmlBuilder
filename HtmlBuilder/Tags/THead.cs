namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Group of heading rows in a table
    /// </summary>
    public class THead : GlobalElement
    {
        private const string name = "thead";
        public override string TagName => name;
    }
}
