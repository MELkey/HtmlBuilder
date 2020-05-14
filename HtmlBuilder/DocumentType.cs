using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder
{
    public enum DocumentType
    {
        [Description("<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\">")]
        Html401,

        [Description("<!DOCTYPE html>")]
        Html5
    }
}
