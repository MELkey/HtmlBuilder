namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Link to the source of the quotation or more information about the edit
    /// </summary>
    public sealed class Cite : AttributeBase<string>
    {
        private const string name = "cite";

        public override string AttributeName => name;
    }
}
