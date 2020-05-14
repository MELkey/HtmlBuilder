namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Name of the element to use for form submission and in the form.elements API
    /// </summary>
    public sealed class Name : AttributeBase<string>
    {
        private const string name = "name";

        public override string AttributeName => name;
    }
}
