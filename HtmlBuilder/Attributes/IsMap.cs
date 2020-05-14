namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the image is a server-side image map
    /// </summary>
    public class IsMap : AttributeBase<bool>
    {
        private const string name = "ismap";

        public override string AttributeName => name;
    }
}
