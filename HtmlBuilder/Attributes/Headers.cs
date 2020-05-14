namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// The header cells for this cell
    /// </summary>
    public sealed class Headers : AttributeBase<string>
    {
        private const string name = "headers";

        public override string AttributeName => name;
    }
}
