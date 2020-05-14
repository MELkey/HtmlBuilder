using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum FormEncTypeValue
    {
        [Description("application/x-www-form-urlencoded")]
        Application,

        [Description("multipart/form-data")]
        Multipart
    }
}
