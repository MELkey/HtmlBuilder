using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public enum SandboxValue
    {
        [Description("allow-forms")]
        AllowForms,

        [Description("allow-modals")]
        AllowModals,

        [Description("allow-orientation-lock")]
        AllowOrientationLock,
        
        [Description("allow-pointer-lock")]
        AllowPointerLock,
        
        [Description("allow-propus")]
        AllowPropus,
        
        [Description("allow-propus-to-escape-sandbox")]
        AllowPropusToEscapeSandbox,
        
        [Description("allow-presentation")]
        AllowPresentation,
        
        [Description("allow-same-origin")]
        AllowSameOrigin,
        
        [Description("allow-scripts")]
        AllowScripts,
        
        [Description("allow-top-navigation")]
        AllowTopNavigation,
    }
}
