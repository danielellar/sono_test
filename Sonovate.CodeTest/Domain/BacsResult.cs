﻿namespace Sonovate.CodeTest.Domain
{
    public class BacsResult : IBacsResult
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string SortCode { get; set; }
        public object Amount { get; set; }
        public string Ref { get; set; }
    }
}