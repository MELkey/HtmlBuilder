using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public class Tokens : ITokens
    {
        public Tokens(string open, string close, string closePrefix, string indent, string whiteSpace)
        {
            Open = open;
            Close = close;
            ClosePrefix = closePrefix;
            Indent = indent;
            WhiteSpace = whiteSpace;
        }

        public string Open { get; }
        public string Close { get; }
        public string ClosePrefix { get; }
        public string Indent { get; }
        public string WhiteSpace { get; }
    }
}
