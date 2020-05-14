namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Images to use in different situations (e.g., high-resolution displays, small monitors, etc.)
    /// </summary>
    public sealed class SrcSet : AttributeBase<string>
    {
        private const string name = "srcset";

        public override string AttributeName => name;
    }
}
