namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Date and (optionally) time of the change
    /// </summary>
    public sealed class DateTime : AttributeBase<string>
    {
        private const string name = "datetime";

        public override string AttributeName => name;
    }
}
