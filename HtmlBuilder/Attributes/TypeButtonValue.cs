using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum TypeButtonValue
    {
        [Description("submit")]
        Submit,

        [Description("reset")]
        Reset,

        [Description("button")]
        Button
    }
}
