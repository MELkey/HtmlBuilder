using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public class HtmlSerializerSettings : IHtmlSerializerSettings
    {
        public HtmlSerializerSettings()
            : this(
                  indentCount: 4,
                  useParrentIndent: false,
                  useCompactStyle: true,
                  tokens: new Tokens())
        {
        }

        public HtmlSerializerSettings(int indentCount, bool useParrentIndent, bool useCompactStyle, ITokens tokens)
        {
            IndentCount = indentCount;
            UseParrentIndent = useParrentIndent;
            UseCompactStyle = useCompactStyle;
            Tokens = tokens ?? throw new ArgumentNullException(nameof(tokens));
        }

        public int IndentCount { get; }        
        public bool UseParrentIndent { get; }        
        public bool UseCompactStyle { get; }
        public ITokens Tokens { get; }
    }
}
