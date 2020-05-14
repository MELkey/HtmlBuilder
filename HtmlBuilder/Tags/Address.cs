namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Contact information for a page or article element
    /// </summary>
    public class Address : GlobalElement
    {
        private const string name = "address";
        public override string TagName => name;
    }
}
