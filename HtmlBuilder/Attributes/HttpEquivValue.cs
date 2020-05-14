using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum HttpEquivValue
    {
        [Description("content-type")]
        ContentType,

        [Description("default-style")]
        DefaultStyle,

        [Description("refresh")]
        Refresh,

        [Description("x-ua-compatible")]
        XUACompatible,

        [Description("content-security-policy")]
        ContentSecurityPolicy
    }
}
