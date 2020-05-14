namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// How the element handles crossorigin requests
    /// </summary>
    public sealed class CrossOrigin : AttributeBase<CrossOriginValues>
    {
        private const string name = "crossorigin";

        public override string AttributeName => name;
    }
}
