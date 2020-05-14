namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether to allow the value to be edited by the user
    /// </summary>
    public sealed class ReadOnly : AttributeBase<bool>
    {
        private const string name = "readonly";

        public override string AttributeName => name;
    }
}
