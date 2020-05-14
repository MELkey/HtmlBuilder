using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum KindValue
    {
        [Description("subtitles")]
        SubTitles,
        [Description("captions")]
        Captions,
        [Description("descriptions")]
        Descriptions,
        [Description("chapters")]
        chapters,
        [Description("metadata")]
        MetaData
    }
}
