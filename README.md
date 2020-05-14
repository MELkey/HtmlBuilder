# HtmlBuilder
Simple fluent html builder
### Example:

```csharp
var element = ElementFactory.Create(e => e.Div)
                .AddAttribute(a => a.Id, i => i.SetValue("selector"))
                    .AddChild(e => e.Div)
                    .AddAttribute(a => a.Class, c => c.SetValue("custom_class"))
                .Root;
```

### String result:

```html
<div id=""selector"">
  <div class=""custom_class""/>
</div>
```
