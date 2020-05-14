namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Address of the resource
    /// </summary>
    public sealed class Src : AttributeBase<string>
    {
        private const string name = "src";

        public override string AttributeName => name;
    }
}
