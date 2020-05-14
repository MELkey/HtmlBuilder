namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Line break, e.g. in poem or postal address
    /// </summary>
    public class Br : GlobalElement
    {
        private const string name = "br";
        public override string TagName => name;
    }
}
