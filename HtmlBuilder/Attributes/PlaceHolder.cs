namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// User-visible label to be placed within the form control
    /// </summary>
    public sealed class PlaceHolder : AttributeBase<string>
    {
        private const string name = "placeholder";

        public override string AttributeName => name;
    }
}
