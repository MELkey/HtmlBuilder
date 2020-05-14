namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// The type of text track
    /// </summary>
    public sealed class Kind : AttributeBase<KindValue>
    {
        private const string name = "kind";

        public override string AttributeName => name;
    }
}
