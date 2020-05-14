using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum TypeOlValue
    {
        [Description("1")]
        Integer,

        [Description("a")]
        ALowercase,

        [Description("A")]
        AUppercase,

        [Description("i")]
        ILowercase,

        [Description("I")]
        IUppercase
    }
}
