using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder
{
    public interface IHtmlSerializerFactory
    {
        IHtmlSerializer Create(Document document);
        IHtmlSerializer Create(IElement element);
    }
}
