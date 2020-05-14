namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Bypass form control validation for form submission
    /// </summary>
    public class NoValidate : AttributeBase<bool>
    {
        private const string name = "novalidate";

        public override string AttributeName => name;
    }
}
