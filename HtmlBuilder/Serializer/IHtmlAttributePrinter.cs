﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlBuilder.Serializer
{
    public interface IHtmlAttributePrinter
    {
        string PrintAttribute(IAttribute attribute);
    }
}
