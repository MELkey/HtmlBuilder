namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether to allow the iframe's contents to use requestFullscreen()
    /// </summary>
    public sealed class AllowFullScreen : AttributeBase<bool>
    {
        private const string name = "allowfullscreen";

        public override string AttributeName => name;
    }
}
