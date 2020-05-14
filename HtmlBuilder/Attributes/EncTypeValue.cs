using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum EncTypeValue
    {
        [Description("application/x-www-form-urlencoded")]
        Application,

        [Description("multipart/form-data")]
        Multipart,

        [Description("text/plain")]
        Text
    }
}
