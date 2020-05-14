namespace HtmlBuilder.Attributes
{
    public abstract class AttributeBase<TValue> : IAttribute<TValue>
    {
        private object value;
        public virtual void SetValue(TValue value)
        {
            this.value = value;
        }

        public object Value => value ?? default(TValue);

        public abstract string AttributeName { get; }
    }
}
