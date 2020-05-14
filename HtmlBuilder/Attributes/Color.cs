namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Color to use when customizing a site's icon (for rel="mask-icon")
    /// </summary>
    public sealed class Color : AttributeBase<string>
    {
        private const string name = "color";

        public override string AttributeName => name;
    }
}
