namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Variant to use for form submission
    /// </summary>
    public sealed class Method : AttributeBase<MethodValue>
    {
        private const string name = "method";

        public override string AttributeName => name;
    }
}
