namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Defer script execution
    /// </summary>
    public sealed class Defer : AttributeBase<bool>
    {
        private const string name = "defer";

        public override string AttributeName => name;
    }
}
