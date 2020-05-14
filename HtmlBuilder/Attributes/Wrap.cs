namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// How the value of the form control is to be wrapped for form submission
    /// </summary>
    public sealed class Wrap : AttributeBase<WrapValue>
    {
        private const string name = "wrap";

        public override string AttributeName => name;
    }
}
