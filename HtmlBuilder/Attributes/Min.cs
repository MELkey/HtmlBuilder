namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Minimum value
    /// </summary>
    public sealed class Min : AttributeBase<float>
    {
        private const string name = "min";

        public override string AttributeName => name;
    }
}
