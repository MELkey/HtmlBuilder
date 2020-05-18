using HtmlBuilder.Tags;
using System;
using System.Linq.Expressions;

namespace HtmlBuilder
{
    public interface IElement<TTag, TParent> : IElement
        where TTag : GlobalElement, new()
        where TParent : IElement
    {
        new TParent Parent { get; }

        IElement<TTag, TParent> AddAttribute<TAttribute>(Expression<Func<TTag, TAttribute>> attributeSelector, Expression<Action<TAttribute>> valueAction) where TAttribute : IAttribute, new();
        IElement<TChildAttributesSet, IElement<TTag, TParent>> AddChild<TChildAttributesSet, TParrentOld>(IElement<TChildAttributesSet, TParrentOld> element)
            where TChildAttributesSet : GlobalElement, new()
            where TParrentOld : IElement;
        IElement<TChildAttributesSet, IElement<TTag, TParent>> AddChild<TChildAttributesSet>(Expression<Func<ITagSet<TParent>, IElement<TChildAttributesSet, TParent>>> tagSelector) where TChildAttributesSet : GlobalElement, new();
        IElement<TChildAttributesSet, IElement<TTag, TParent>> AddChild<TChildAttributesSet>(Expression<Func<ITagSet<TParent>, IElement<TChildAttributesSet, TParent>>> tagSelector, out IElement<TChildAttributesSet, IElement<TTag, TParent>> child) where TChildAttributesSet : GlobalElement, new();
        IElement<TTag, TParent> AddContent(string content);
        IElement<TTag, TParent> AddCustomAttribute(string name, string value);
        IElement<CustomTag, IElement<TTag, TParent>> AddCustomChild(string name);
    }
}