using System.IO;

namespace HtmlBuilder
{
    public interface IHtmlSerializer
    {
        void Serialize(TextWriter textWriter);
    }
}