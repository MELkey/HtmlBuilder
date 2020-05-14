namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Minimum length of value
    /// </summary>
    public sealed class MinLength : AttributeBase<uint>
    {
        private const string name = "minlength";

        public override string AttributeName => name;
    }
}
