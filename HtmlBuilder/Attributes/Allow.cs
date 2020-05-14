namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Feature policy to be applied to the iframe's contents
    /// </summary>
    public sealed class Allow : AttributeBase<string>
    {
        private const string name = "allow";

        public override string AttributeName => name;
    }
}
