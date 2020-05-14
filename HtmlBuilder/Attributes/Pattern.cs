namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Pattern to be matched by the form control's value
    /// </summary>
    public sealed class Pattern : AttributeBase<string>
    {
        private const string name = "pattern";

        public override string AttributeName => name;
    }
}
