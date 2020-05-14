namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// High limit of low range
    /// </summary>
    public sealed class Low : AttributeBase<float>
    {
        private const string name = "low";

        public override string AttributeName => name;
    }
}
