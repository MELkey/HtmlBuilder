using HtmlBuilder.Attributes;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HtmlBuilder
{
    public interface IElement
    {
        IReadOnlyCollection<IAttribute> Attributes { get; }
        IReadOnlyCollection<IElement> Childs { get; }
        IReadOnlyCollection<string> Content { get; }
        Document Document { get; }
        string Name { get; }
        IElement Parent { get; }
        IElement Root { get; }
    }
}