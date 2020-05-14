namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Enable the track if no other text track is more suitable
    /// </summary>
    public sealed class Default : AttributeBase<bool>
    {
        private const string name = "default";

        public override string AttributeName => name;
    }
}
