using System;

namespace Sonovate.CodeTest.Domain
{
    internal interface IInvoiceTransaction
    {
        decimal Gross { get; set; }
        DateTime? InvoiceDate { get; set; }
        string InvoiceId { get; set; }
        string InvoiceRef { get; set; }
        string SupplierId { get; set; }
    }
}