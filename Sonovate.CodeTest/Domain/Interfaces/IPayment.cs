using System;

namespace Sonovate.CodeTest.Domain
{
    internal interface IPayment
    {
        string AgencyId { get; set; }
        decimal Balance { get; set; }
        DateTime PaymentDate { get; set; }
    }
}