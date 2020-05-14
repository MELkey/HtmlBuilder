namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Value of the element
    /// </summary>
    public sealed class Content : AttributeBase<string>
    {
        private const string name = "content";

        public override string AttributeName => name;
    }
}
