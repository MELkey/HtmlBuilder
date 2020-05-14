namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Associate the label with form control
    /// </summary>
    public sealed class For : AttributeBase<string>
    {
        private const string name = "for";

        public override string AttributeName => name;
    }
}
