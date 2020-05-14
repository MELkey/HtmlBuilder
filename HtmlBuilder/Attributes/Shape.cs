using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// The kind of shape to be created in an image map
    /// </summary>
    public sealed class Shape : AttributeBase<ShapeValue>
    {
        private const string name = "shape";

        public override string AttributeName => name;
    }
}
