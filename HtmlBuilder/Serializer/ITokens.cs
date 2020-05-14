namespace HtmlBuilder.Serializer
{
    public interface ITokens
    {
        string Close { get; }
        string ClosePrefix { get; }
        string Indent { get; }
        string Open { get; }
        string WhiteSpace { get; }
    }
}