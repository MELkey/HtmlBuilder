namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Address of the resource
    /// </summary>
    public sealed class Data : AttributeBase<string>
    {
        private const string name = "data";

        public override string AttributeName => name;
    }
}
