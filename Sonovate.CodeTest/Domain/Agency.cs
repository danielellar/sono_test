namespace Sonovate.CodeTest.Domain
{
    public class Agency : IAgency
    {
        public string Id { get; set; }
        public BankDetails BankDetails { get; set; }
    }
}