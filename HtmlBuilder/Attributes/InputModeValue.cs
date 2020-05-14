using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum InputModeValue
    {
        [Description("none")]
        None,

        [Description("tetx")]
        Text,

        [Description("tel")]
        Tel,

        [Description("email")]
        Email,

        [Description("url")]
        Url,

        [Description("numeric")]
        Numeric,

        [Description("decimal")]
        Decimal,

        [Description("search")]
        Search
    }
}
