namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the iframe's contents are allowed to use the PaymentRequest interface to make payment requests
    /// </summary>
    public sealed class AllowPaymentRequest : AttributeBase<bool>
    {
        private const string name = "allowpaymentrequest";

        public override string AttributeName => name;
    }
}
