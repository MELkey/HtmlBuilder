namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Optimum value in gauge
    /// </summary>
    public class Optimum : AttributeBase<float>
    {
        private const string name = "optimum";

        public override string AttributeName => name;
    }
}
