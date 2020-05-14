namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Type
    /// </summary>
    public sealed class Type : AttributeBase<string>
    {
        private const string name = "type";

        public override string AttributeName => name;
    }
}
