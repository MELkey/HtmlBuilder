namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Decoding hint to use when processing this image for presentation
    /// </summary>
    public sealed class Decoding : AttributeBase<DecodingValue>
    {
        private const string name = "decoding";

        public override string AttributeName => name;

    }
}
