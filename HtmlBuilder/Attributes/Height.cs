namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Vertical dimension
    /// </summary>
    public sealed class Height : AttributeBase<uint>
    {
        private const string name = "height";

        public override string AttributeName => name;
    }
}
