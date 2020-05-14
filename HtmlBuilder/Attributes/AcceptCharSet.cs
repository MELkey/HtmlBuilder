namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Character encodings to use for form submission
    /// </summary>
    public sealed class AcceptCharSet : AttributeBase<string>
    {
        private const string name = "accept-charset";

        public override string AttributeName => name;
    }
}
