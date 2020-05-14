namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Starting value of the list
    /// </summary>
    public sealed class Start : AttributeBase<int>
    {
        private const string name = "start";

        public override string AttributeName => name;
    }
}
