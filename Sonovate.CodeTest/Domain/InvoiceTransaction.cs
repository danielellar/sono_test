﻿using System;

namespace Sonovate.CodeTest.Domain
{
    internal class InvoiceTransaction : IInvoiceTransaction
    {
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceId { get; set; }
        public string SupplierId { get; set; }
        public decimal Gross { get; set; }
        public string InvoiceRef { get; set; }
    }
}