namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Applicable media
    /// </summary>
    public sealed class Media : AttributeBase<string>
    {
        private const string name = "media";

        public override string AttributeName => name;
    }
}
