using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum ScopeValue
    {
        [Description("col")]
        Col,

        [Description("colgroup")]
        ColGroup,

        [Description("row")]
        Row,

        [Description("rowgroup")]
        RowGroup
    }
}
