namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Type of form control
    /// </summary>
    public sealed class TypeInput : AttributeBase<TypeKeyWordValue>
    {
        private const string name = "type";

        public override string AttributeName => name;
    }
}
