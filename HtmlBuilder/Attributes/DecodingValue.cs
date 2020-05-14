using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum DecodingValue
    {
        [Description("sync")]
        Sync,

        [Description("async")]
        Async,

        [Description("auto")]
        Auto
    }
}
