namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Entry list encoding type to use for form submission
    /// </summary>
    public sealed class FormEncType : AttributeBase<FormEncTypeValue>
    {
        private const string name = "formenctypevalue";

        public override string AttributeName => name;
    }
}
