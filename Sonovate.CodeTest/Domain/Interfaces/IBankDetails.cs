namespace Sonovate.CodeTest.Domain
{
    public interface IBankDetails
    {
        string AccountName { get; set; }
        string AccountNumber { get; set; }
        string SortCode { get; set; }
    }
}