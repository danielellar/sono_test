namespace Sonovate.CodeTest.Domain
{
    public interface IBacsResult
    {
        string AccountName { get; set; }
        string AccountNumber { get; set; }
        object Amount { get; set; }
        string Ref { get; set; }
        string SortCode { get; set; }
    }
}