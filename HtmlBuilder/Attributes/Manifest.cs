namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Application cache manifest
    /// </summary>
    public sealed class Manifest : AttributeBase<string>
    {
        private const string name = "manifest";

        public override string AttributeName => name;
    }
}
