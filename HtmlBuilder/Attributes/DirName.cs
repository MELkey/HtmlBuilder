namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Name of form control to use for sending the element's directionality in form submission
    /// </summary>
    public sealed class DirName : AttributeBase<string>
    {
        private const string name = "dirname";

        public override string AttributeName => name;
    }
}
