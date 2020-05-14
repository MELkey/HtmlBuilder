namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Size of the control
    /// </summary>
    public sealed class Size : AttributeBase<uint>
    {
        private const string name = "size";

        public override string AttributeName => name;
    }
}
