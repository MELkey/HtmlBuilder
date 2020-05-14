namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Maximum length of value
    /// </summary>
    public sealed class MaxLength : AttributeBase<uint>
    {
        private const string name = "maxlength";

        public override string AttributeName => name;
    }
}
