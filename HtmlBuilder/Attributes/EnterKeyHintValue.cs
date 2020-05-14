using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum EnterKeyHintValue
    {
        [Description("enter")]
        Enter,

        [Description("done")]
        Done,

        [Description("go")]
        Go,

        [Description("next")]
        Next,

        [Description("previous")]
        Previous,

        [Description("search")]
        Search,

        [Description("send")]
        Send
    }
}
