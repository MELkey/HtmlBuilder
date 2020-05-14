using System;

namespace HtmlBuilder.Tags
{
    public class CustomTag : GlobalElement
    {
        protected string name;

        public CustomTag()
        {
            throw new Exception("Custom tag unnamed");
        }

        internal CustomTag(string name)
        {
            this.name = name;
        }

        public override string TagName => name;
    }
}
