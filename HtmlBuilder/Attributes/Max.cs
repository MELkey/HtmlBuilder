namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Maximum value
    /// </summary>
    public sealed class Max : AttributeBase<float>
    {
        private const string name = "max";

        public override string AttributeName => name;
    }
}
