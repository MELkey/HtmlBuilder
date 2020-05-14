namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Entry list encoding type to use for form submission
    /// </summary>
    public sealed class EncType : AttributeBase<EncTypeValue>
    {
        private const string name = "enctype";

        public override string AttributeName => name;
    }
}
