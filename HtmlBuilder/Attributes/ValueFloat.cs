namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Current value of the element
    /// </summary>
    public sealed class ValueFloat : AttributeBase<float>
    {
        private const string name = "value";

        public override string AttributeName => name;
    }
}
