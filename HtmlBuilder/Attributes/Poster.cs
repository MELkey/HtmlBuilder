namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Poster frame to show prior to video playback
    /// </summary>
    public sealed class Poster : AttributeBase<string>
    {
        private const string name = "poster";

        public override string AttributeName => name;
    }
}
