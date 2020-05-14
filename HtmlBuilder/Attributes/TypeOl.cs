namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Kind of list marker
    /// </summary>
    public sealed class TypeOl : AttributeBase<TypeOlValue>
    {
        private const string name = "type";

        public override string AttributeName => name;
    }
}
