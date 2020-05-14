namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Encourage the user agent to display video content within the element's playback area
    /// </summary>
    public sealed class PlaysInLine : AttributeBase<bool>
    {
        private const string name = "playsinline";

        public override string AttributeName => name;
    }
}
