using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum MethodValue
    {
        [Description("GET")]
        Get,

        [Description("POST")]
        Post,

        [Description("dialog")]
        Dialog
    }
}
