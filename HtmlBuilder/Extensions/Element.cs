namespace HtmlBuilder.Extensions
{
    public static class Element
    {
        /// <summary>
        /// Calculates the nesting depth relative to the root element
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int CalculateDeep(this IElement element)
        {
            var deep = element.Parent == null ?
                0 :
                element.Parent.CalculateDeep() + 1;

            return deep;
        }

        public static bool IsInline(this IElement element)
        {
            var content = element.Content;
            var hasChilds = element.Childs.Count > 0;
            var isInline = (content.Count == 1 || content.Count == 0) && !hasChilds;

            return isInline;
        }

        public static bool IsEmpty(this IElement element)
        {
            var notHasContent = element.Content.Count == 0;
            var notHasChilds = element.Childs.Count == 0;

            return notHasContent && notHasChilds;
        }
    }
}
