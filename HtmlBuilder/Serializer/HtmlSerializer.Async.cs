using HtmlBuilder.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder.Serializer
{
    public partial class HtmlSerializer
    {
        public async Task SerializeAsync(TextWriter textWriter)
        {
            if (document != null)
            {
                await textWriter.WriteAsync(document.TypeValue).ConfigureAwait(false);
                await textWriter.WriteLineAsync().ConfigureAwait(false);
            }

            await SerializeElementAsync(element, textWriter).ConfigureAwait(false);
        }

        private async Task SerializeElementAsync(IElement element, TextWriter textWriter)
        {
            if (element != this.element)
                await textWriter.WriteLineAsync().ConfigureAwait(false);

            await OpenTagAsync(element, textWriter).ConfigureAwait(false);
            var isInline = element.IsInline();

            if (!isInline)
                foreach (var child in element.Childs)
                    await SerializeElementAsync(child, textWriter).ConfigureAwait(false);

            await AddContentAsync(element, textWriter).ConfigureAwait(false);

            if (!isInline)
                await textWriter.WriteLineAsync().ConfigureAwait(false);

            await CloseTagAsync(element, textWriter).ConfigureAwait(false);
        }

        private async Task OpenTagAsync(IElement element, TextWriter textWriter)
        {
            await AddIndentAsync(element, textWriter).ConfigureAwait(false);
            await textWriter.WriteAsync(settings.Tokens.Open).ConfigureAwait(false);
            await textWriter.WriteAsync(element.Name).ConfigureAwait(false);

            var attributes = element.Attributes;

            if (attributes.Count > 0)
                await AddAttributesAsync(attributes, textWriter).ConfigureAwait(false);

            if (!NeedUseCompactStyle(element))
                await textWriter.WriteAsync(settings.Tokens.Close).ConfigureAwait(false);
        }

        private async Task CloseTagAsync(IElement element, TextWriter textWriter)
        {
            if (!element.IsInline())
                await AddIndentAsync(element, textWriter).ConfigureAwait(false);

            if (NeedUseCompactStyle(element))
                await CloseTagCompactAsync(textWriter).ConfigureAwait(false);
            else
                await CloseTagUnCompactAsync(element, textWriter).ConfigureAwait(false);
        }

        private async Task CloseTagCompactAsync(TextWriter textWriter)
        {
            await textWriter.WriteAsync(settings.Tokens.ClosePrefix).ConfigureAwait(false);
            await textWriter.WriteAsync(settings.Tokens.Close).ConfigureAwait(false);
        }

        private async Task CloseTagUnCompactAsync(IElement element, TextWriter textWriter)
        {
            await textWriter.WriteAsync(settings.Tokens.Open).ConfigureAwait(false);
            await textWriter.WriteAsync(settings.Tokens.ClosePrefix).ConfigureAwait(false);
            await textWriter.WriteAsync(element.Name).ConfigureAwait(false);
            await textWriter.WriteAsync(settings.Tokens.Close).ConfigureAwait(false);
        }

        private async Task AddIndentAsync(IElement element, TextWriter textWriter)
        {
            var deep = settings.UseParrentIndent ?
                element.CalculateDeep() :
                element.CalculateDeep() - this.element.CalculateDeep();

            foreach (var level in Enumerable.Range(0, deep))
                foreach (var step in Enumerable.Range(0, settings.IndentCount))
                    await textWriter.WriteAsync(settings.Tokens.Indent).ConfigureAwait(false);
        }

        private async Task AddAttributesAsync(IReadOnlyCollection<IAttribute> attributes, TextWriter textWriter)
        {
            foreach (var attribute in attributes)
            {
                var stringValue = htmlAttributePrinter.Print(attribute);
                if (string.IsNullOrEmpty(stringValue))
                    continue;

                await textWriter.WriteAsync(settings.Tokens.WhiteSpace).ConfigureAwait(false);
                await textWriter.WriteAsync(stringValue).ConfigureAwait(false);
            }
        }

        private async Task AddContentAsync(IElement element, TextWriter textWriter)
        {
            var content = element.Content;
            var hasContent = content.Count > 0;

            if (!hasContent)
                return;

            var isInline = element.IsInline();

            if (hasContent && !isInline)
                await textWriter.WriteLineAsync().ConfigureAwait(false);

            if (isInline)
            {
                await textWriter.WriteAsync(content.First()).ConfigureAwait(false);
            }
            else
            {
                foreach (var contentElement in content)
                {
                    await AddIndentAsync(element, textWriter).ConfigureAwait(false);
                    await textWriter.WriteAsync(contentElement).ConfigureAwait(false);
                    await textWriter.WriteLineAsync().ConfigureAwait(false);
                }
            }
        }
    }
}
