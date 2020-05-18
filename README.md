# HtmlBuilder
Simple fluent html builder
### Example:

```csharp
var elementFactory = new ElementFactory();
var element = elementFactory.Create(e => e.Div)
                .AddAttribute(a => a.Id).Setup(i => i.SetValue("selector"))
                    .AddChild(e => e.Div)
                    .AddAttribute(a => a.Class).Setup(c => c.SetValue("custom_class"))
                .Root;
```

### String result:

```html
<div id="selector">
  <div class="custom_class"/>
</div>
```
