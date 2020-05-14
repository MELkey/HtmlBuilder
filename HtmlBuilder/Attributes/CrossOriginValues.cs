using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum CrossOriginValues
    {
        [Description("anonymous")]
        Anonymous,

        [Description("use-credentials")]
        UseCredentials
    }
}
