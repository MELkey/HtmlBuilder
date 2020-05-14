namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Pragma directive
    /// </summary>
    public sealed class HttpEquiv : AttributeBase<HttpEquivValue>
    {
        private const string name = "http-equiv";

        public override string AttributeName => name;
    }
}
