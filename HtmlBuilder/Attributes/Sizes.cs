namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Image sizes for different page layouts
    /// </summary>
    public sealed class Sizes : AttributeBase<string>
    {
        private const string name = "sizes";

        public override string AttributeName => name;
    }
}
