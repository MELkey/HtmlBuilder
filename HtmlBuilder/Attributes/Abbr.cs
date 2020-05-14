namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Alternative label to use for the header cell when referencing the cell in other contexts
    /// </summary>
    public sealed class Abbr : AttributeBase<string>
    {
        private const string name = "abbr";

        public override string AttributeName => name;
    }
}
