﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum DirValue
    {
        [Description("ltr")]
        Ltr,

        [Description("rtl")]
        Rtl,

        [Description("auto")]
        Auto,
    }
}
