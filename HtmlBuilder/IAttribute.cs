namespace HtmlBuilder
{
    public interface IAttribute
    {
        string AttributeName { get; }
        object Value { get; }
    }
}