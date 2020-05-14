using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Coordinates for the shape to be created in an image map
    /// </summary>
    public sealed class Coords : AttributeBase<string>
    {
        private const string name = "coords";

        public override string AttributeName => name;
    }
}
