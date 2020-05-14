namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Variant to use for form submission
    /// </summary>
    public sealed class FormMethod : AttributeBase<MethodValue>
    {
        private const string name = "formmethod";

        public override string AttributeName => name;
    }
}
