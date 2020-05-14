namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Variable
    /// </summary>
    public class Var : GlobalElement
    {
        private const string name = "var";
        public override string TagName => name;
    }
}
