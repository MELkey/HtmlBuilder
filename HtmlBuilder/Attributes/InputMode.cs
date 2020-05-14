using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Hint for selecting an input modality
    /// </summary>
    public sealed class InputMode : AttributeBase<InputModeValue>
    {
        private const string name = "inputmode";

        public override string AttributeName => name;
    }
}
