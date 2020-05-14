namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// A document to render in the iframe
    /// </summary>
    public sealed class SrcDoc : AttributeBase<string>
    {
        private const string name = "srcdoc";

        public override string AttributeName => name;
    }
}
