namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Character encoding declaration
    /// </summary>
    public sealed class CharSet : AttributeBase<string>
    {
        private const string name = "charset";

        public override string AttributeName => name;
    }
}
