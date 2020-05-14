namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Potential destination for a preload request (for rel="preload" and rel="modulepreload")
    /// </summary>
    public sealed class As : AttributeBase<string>
    {
        private const string name = "as";

        public override string AttributeName => name;
    }
}
