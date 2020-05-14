namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Integrity metadata used in Subresource Integrity checks [SRI]
    /// </summary>
    public sealed class Integrity : AttributeBase<string>
    {
        private const string name = "integrity";

        public override string AttributeName => name;
    }
}
