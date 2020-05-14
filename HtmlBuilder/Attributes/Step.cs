namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Granularity to be matched by the form control's value
    /// </summary>
    public sealed class Step : AttributeBase<float>
    {
        private const string name = "step";

        public override string AttributeName => name;
    }
}
