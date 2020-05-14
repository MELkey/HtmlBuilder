namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Hint that the media resource can be started automatically when the page is loaded
    /// </summary>
    public sealed class AutoPlay : AttributeBase<bool>
    {
        private const string name = "autoplay";

        public override string AttributeName => name;
    }
}
