namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Hint for expected file type in file upload controls
    /// </summary>
    public sealed class Accept : AttributeBase<string>
    {
        private const string name = "accept";

        public override string AttributeName => name;
    }
}
