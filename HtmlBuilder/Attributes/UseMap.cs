namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Name of image map to use
    /// </summary>
    public sealed class UseMap : AttributeBase<string>
    {
        private const string name = "usemap";

        public override string AttributeName => name;
    }
}
