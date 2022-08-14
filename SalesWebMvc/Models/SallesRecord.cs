using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SallesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SallesRecord() { }
        public SallesRecord(DateTime date, double amount, SalleStatus status, Seller seller)
        {
            
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
