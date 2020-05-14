namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the form control is disabled
    /// </summary>
    public sealed class Disabled : AttributeBase<bool>
    {
        private const string name = "disabled";

        public override string AttributeName => name;
    }
}
