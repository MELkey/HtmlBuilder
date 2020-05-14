namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether to mute the media resource by default
    /// </summary>
    public sealed class Muted : AttributeBase<bool>
    {
        private const string name = "muted";

        public override string AttributeName => name;
    }
}
