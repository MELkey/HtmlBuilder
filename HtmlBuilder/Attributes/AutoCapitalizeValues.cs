using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum AutoCapitalizeValues
    {
        [Description("on")]
        On,

        [Description("off")]
        Off,

        [Description("none")]
        None,

        [Description("sentences")]
        Sentences,

        [Description("words")]
        Words,

        [Description("characters")]
        Characters
    }
}
