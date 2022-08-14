using System;
using System.Linq;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SallesRecord.Any())
            {
                return;
            }

            Department d1 = new Department("Computers");
            Department d2 = new Department("Eletronics");
            Department d3 = new Department("Fashion");
            Department d4 = new Department("Books");

            Seller s1 = new Seller("Rogério Nascimento", "rogerionascimento.dev@gmail.com",new DateTime(1992,3,18),2.500, d1);
            Seller s2 = new Seller("Vanessa Leite Oliveira", "vanessa@gmail.com", new DateTime(1994, 7, 28), 1.500, d3);
            Seller s3 = new Seller("Sandra Oliveira", "sandra@gmail.com", new DateTime(1974, 9, 20), 1.700, d2);
            Seller s4 = new Seller("Natália Oliveira", "natalia@gmail.com", new DateTime(2000, 9, 20), 1.200, d4);            
            Seller s5 = new Seller("Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller("Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SallesRecord r1 = new SallesRecord(new DateTime(2018, 09, 25), 11000.0, SalleStatus.Billed, s1);
            SallesRecord r2 = new SallesRecord(new DateTime(2018, 09, 4), 7000.0, SalleStatus.Billed, s5);
            SallesRecord r3 = new SallesRecord(new DateTime(2018, 09, 13), 4000.0, SalleStatus.Canceled, s4);
            SallesRecord r4 = new SallesRecord(new DateTime(2018, 09, 1), 8000.0, SalleStatus.Billed, s1);
            SallesRecord r5 = new SallesRecord(new DateTime(2018, 09, 21), 3000.0, SalleStatus.Billed, s3);
            SallesRecord r6 = new SallesRecord(new DateTime(2018, 09, 15), 2000.0, SalleStatus.Billed, s1);
            SallesRecord r7 = new SallesRecord(new DateTime(2018, 09, 28), 13000.0, SalleStatus.Billed, s2);
            SallesRecord r8 = new SallesRecord(new DateTime(2018, 09, 11), 4000.0, SalleStatus.Billed, s4);
            SallesRecord r9 = new SallesRecord(new DateTime(2018, 09, 14), 11000.0, SalleStatus.Pending, s6);
            SallesRecord r10 = new SallesRecord(new DateTime(2018, 09, 7), 9000.0, SalleStatus.Billed, s6);
            SallesRecord r11 = new SallesRecord(new DateTime(2018, 09, 13), 6000.0, SalleStatus.Billed, s2);
            SallesRecord r12 = new SallesRecord(new DateTime(2018, 09, 25), 7000.0, SalleStatus.Pending, s3);
            SallesRecord r13 = new SallesRecord(new DateTime(2018, 09, 29), 10000.0, SalleStatus.Billed, s4);
            SallesRecord r14 = new SallesRecord(new DateTime(2018, 09, 4), 3000.0, SalleStatus.Billed, s5);
            SallesRecord r15 = new SallesRecord(new DateTime(2018, 09, 12), 4000.0, SalleStatus.Billed, s1);
            SallesRecord r16 = new SallesRecord(new DateTime(2018, 10, 5), 2000.0, SalleStatus.Billed, s4);
            SallesRecord r17 = new SallesRecord(new DateTime(2018, 10, 1), 12000.0, SalleStatus.Billed, s1);
            SallesRecord r18 = new SallesRecord(new DateTime(2018, 10, 24), 6000.0, SalleStatus.Billed, s3);
            SallesRecord r19 = new SallesRecord(new DateTime(2018, 10, 22), 8000.0, SalleStatus.Billed, s5);
            SallesRecord r20 = new SallesRecord(new DateTime(2018, 10, 15), 8000.0, SalleStatus.Billed, s6);
            SallesRecord r21 = new SallesRecord(new DateTime(2018, 10, 17), 9000.0, SalleStatus.Billed, s2);
            SallesRecord r22 = new SallesRecord(new DateTime(2018, 10, 24), 4000.0, SalleStatus.Billed, s4);
            SallesRecord r23 = new SallesRecord(new DateTime(2018, 10, 19), 11000.0, SalleStatus.Canceled, s2);
            SallesRecord r24 = new SallesRecord(new DateTime(2018, 10, 12), 8000.0, SalleStatus.Billed, s5);
            SallesRecord r25 = new SallesRecord(new DateTime(2018, 10, 31), 7000.0, SalleStatus.Billed, s3);
            SallesRecord r26 = new SallesRecord(new DateTime(2018, 10, 6), 5000.0, SalleStatus.Billed, s4);
            SallesRecord r27 = new SallesRecord(new DateTime(2018, 10, 13), 9000.0, SalleStatus.Pending, s1);
            SallesRecord r28 = new SallesRecord(new DateTime(2018, 10, 7), 4000.0, SalleStatus.Billed, s3);
            SallesRecord r29 = new SallesRecord(new DateTime(2018, 10, 23), 12000.0, SalleStatus.Billed, s5);
            SallesRecord r30 = new SallesRecord(new DateTime(2018, 10, 12), 5000.0, SalleStatus.Billed, s2);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SallesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
