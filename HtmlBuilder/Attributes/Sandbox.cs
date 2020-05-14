namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Security rules for nested content
    /// </summary>
    public sealed class Sandbox : AttributeBase<SandboxValue[]>
    {
        private const string name = "sandbox";

        public override string AttributeName => name;

        public void SetValue(SandboxValue value)
        {
            base.SetValue(new[] { value });
        }
    }
}
