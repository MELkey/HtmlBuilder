using System.IO;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public interface IHtmlSerializerAsync : IHtmlSerializer
    {
        Task SerializeAsync(TextWriter textWriter);
    }
}
