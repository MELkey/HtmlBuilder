namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Execute script when available, without blocking while fetching
    /// </summary>
    public sealed class Async : AttributeBase<bool>
    {
        private const string name = "async";

        public override string AttributeName => name;
    }
}
