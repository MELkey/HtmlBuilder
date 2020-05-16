using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public class Tokens : ITokens
    {
        public Tokens()
            : this(
                   open: TokenConstants.LessThan.ToString(),
                   close: TokenConstants.GreaterThan.ToString(),
                   closePrefix: TokenConstants.Solidus.ToString(),
                   indent: TokenConstants.WhiteSpace.ToString(),
                   whiteSpace: TokenConstants.WhiteSpace.ToString())
        {
        }

        public Tokens(string open, string close, string closePrefix, string indent, string whiteSpace)
        {
            Open = open ?? throw new ArgumentNullException(nameof(open));
            Close = close ?? throw new ArgumentNullException(nameof(close));
            ClosePrefix = closePrefix ?? throw new ArgumentNullException(nameof(closePrefix));
            Indent = indent ?? throw new ArgumentNullException(nameof(indent));
            WhiteSpace = whiteSpace ?? throw new ArgumentNullException(nameof(whiteSpace));
        }

        public string Open { get; }
        public string Close { get; }
        public string ClosePrefix { get; }
        public string Indent { get; }
        public string WhiteSpace { get; }
    }
}
