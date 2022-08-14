using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SallesRecord> Salles { get; set; } = new List<SallesRecord>();

        public Seller()
        {

        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {            
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSeles(SallesRecord sales)
        {
            Salles.Add(sales);
        }

        public void RemoveSeles(SallesRecord sales)
        {
            Salles.Remove(sales);
        }

        public double TotalSeles(DateTime initial, DateTime final)
        {
            return Salles.Where(s => (s.Date >= initial && s.Date <= final) && s.Status == SalleStatus.Billed).Sum(e => e.Amount);
        }
    }
}
