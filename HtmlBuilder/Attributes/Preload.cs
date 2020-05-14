namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Hints how much buffering the media resource will likely need
    /// </summary>
    public sealed class Preload : AttributeBase<PreloadValue>
    {
        private const string name = "preload";

        public override string AttributeName => name;
    }
}
