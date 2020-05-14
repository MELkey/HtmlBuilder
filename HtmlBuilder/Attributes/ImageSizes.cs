namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Image sizes for different page layouts
    /// </summary>
    public sealed class ImageSizes : AttributeBase<string>
    {
        private const string name = "imagesizes";

        public override string AttributeName => name;
    }
}
