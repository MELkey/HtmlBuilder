using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Tags
{
    /// <summary>
    /// Introductory or navigational aids for a page or section
    /// </summary>
    public class Header : GlobalElement
    {
        private const string name = "header";
        public override string TagName => name;
    }
}
