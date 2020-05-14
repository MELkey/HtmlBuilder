namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Number the list backwards
    /// </summary>
    public sealed class Reversed : AttributeBase<bool>
    {
        private const string name = "reversed";

        public override string AttributeName => name;
    }
}
