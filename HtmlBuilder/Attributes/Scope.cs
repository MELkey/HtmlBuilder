namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Specifies which cells the header cell applies to
    /// </summary>
    public sealed class Scope : AttributeBase<ScopeValue>
    {
        private const string name = "scope";

        public override string AttributeName => name;
    }
}
