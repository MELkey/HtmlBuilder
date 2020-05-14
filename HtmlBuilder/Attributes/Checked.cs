namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the control is checked
    /// </summary>
    public sealed class Checked : AttributeBase<bool>
    {
        private const string name = "checked";

        public override string AttributeName => name;
    }
}
