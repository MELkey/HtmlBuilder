namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Low limit of high range
    /// </summary>
    public sealed class High : AttributeBase<float>
    {
        private const string name = "high";

        public override string AttributeName => name;
    }
}
