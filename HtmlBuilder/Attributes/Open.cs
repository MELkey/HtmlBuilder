namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the details are visible
    /// </summary>
    public class Open : AttributeBase<bool>
    {
        private const string name = "open";

        public override string AttributeName => name;
    }
}
