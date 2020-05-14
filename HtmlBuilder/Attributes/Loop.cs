namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether to loop the media resource
    /// </summary>
    public sealed class Loop : AttributeBase<bool>
    {
        private const string name = "loop";

        public override string AttributeName => name;
    }
}
