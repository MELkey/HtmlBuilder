namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Referrer policy for fetches initiated by the element
    /// </summary>
    public sealed class ReferrerPolicy : AttributeBase<string>
    {
        private const string name = "referrerpolicy";

        public override string AttributeName => name;
    }
}
