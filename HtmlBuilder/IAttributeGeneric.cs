namespace HtmlBuilder
{
    public interface IAttribute<TValue> : IAttribute
    {
        void SetValue(TValue value);
    }
}