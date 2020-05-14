using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum ShapeValue
    {
        [Description("circle")]
        Circle,

        [Description("default")]
        Default,

        [Description("poly")]
        Poly,

        [Description("rect")]
        Rect
    }
}
