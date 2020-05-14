using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum PreloadValue
    {
        [Description("none")]
        None,

        [Description("metadata")]
        MetaData,

        [Description("auto")]
        Auto
    }
}
