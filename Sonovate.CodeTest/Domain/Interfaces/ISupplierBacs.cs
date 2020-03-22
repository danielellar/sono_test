namespace Sonovate.CodeTest.Domain
{
    internal interface ISupplierBacs
    {
        string AccountName { get; set; }
        string AccountNumber { get; set; }
        string InvoiceReference { get; set; }
        decimal PaymentAmount { get; set; }
        string PaymentReference { get; set; }
        string SortCode { get; set; }
    }
}