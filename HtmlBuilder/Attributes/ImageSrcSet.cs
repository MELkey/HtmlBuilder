namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Images to use in different situations (e.g., high-resolution displays, small monitors, etc.)
    /// </summary>
    public sealed class ImageSrcSet : AttributeBase<string>
    {
        private const string name = "imagesrcset";

        public override string AttributeName => name;
    }
}
