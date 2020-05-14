namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Ordinal value of the list item
    /// </summary>
    public sealed class ValueLi : AttributeBase<int>
    {
        private const string name = "value";

        public override string AttributeName => name;
    }
}
