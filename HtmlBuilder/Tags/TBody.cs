namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Group of rows in a table
    /// </summary>
    public class TBody : GlobalElement
    {
        private const string name = "tbody";
        public override string TagName => name;
    }
}
