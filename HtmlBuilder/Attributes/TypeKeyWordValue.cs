using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum TypeKeyWordValue
    {
        [Description("hidden")]
        Hidden,

        [Description("text")]
        Text,

        [Description("search")]
        Search,

        [Description("tel")]
        Tel,

        [Description("url")]
        Url,

        [Description("email")]
        Email,

        [Description("password")]
        Password,

        [Description("date")]
        Date,

        [Description("month")]
        Month,

        [Description("week")]
        Week,

        [Description("time")]
        Time,

        [Description("datetime-local")]
        DateTimeLocal,

        [Description("number")]
        Number,

        [Description("range")]
        Range,

        [Description("color")]
        Color,

        [Description("checkbox")]
        CheckBox,

        [Description("radio")]
        Radio,

        [Description("file")]
        File,

        [Description("submit")]
        Submit,

        [Description("image")]
        Image,

        [Description("reset")]
        Reset,

        [Description("button")]
        Button,
    }
}
