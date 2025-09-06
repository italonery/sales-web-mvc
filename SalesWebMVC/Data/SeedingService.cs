using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");
            Department d5 = new Department(5, "Home & Garden");
            Department d6 = new Department(6, "Sports");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Anna White", "anna@gmail.com", new DateTime(1997, 3, 4), 2800.0, d2);
            Seller s7 = new Seller(7, "Peter Black", "peter@gmail.com", new DateTime(1991, 7, 10), 3100.0, d5);
            Seller s8 = new Seller(8, "Laura Pink", "laura@gmail.com", new DateTime(2001, 5, 25), 3300.0, d6);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2023, 9, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2023, 11, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2024, 2, 11), 4000.0, SaleStatus.Pending, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2024, 3, 4), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2024, 4, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2024, 5, 12), 500.0, SaleStatus.Canceled, s2);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2024, 5, 31), 15000.0, SaleStatus.Billed, s4);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2024, 6, 2), 6500.0, SaleStatus.Billed, s6);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2024, 6, 17), 250.0, SaleStatus.Pending, s8);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2024, 7, 28), 9800.0, SaleStatus.Billed, s7);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2024, 8, 15), 1250.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2024, 9, 3), 13400.0, SaleStatus.Billed, s5);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2024, 10, 22), 2000.0, SaleStatus.Pending, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2024, 11, 19), 780.0, SaleStatus.Billed, s8);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2024, 12, 25), 25000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2025, 1, 5), 4500.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2025, 1, 15), 190.0, SaleStatus.Canceled, s6);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2025, 2, 8), 6200.0, SaleStatus.Billed, s7);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2025, 3, 1), 18000.0, SaleStatus.Pending, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2025, 3, 29), 8900.0, SaleStatus.Billed, s5);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2025, 4, 13), 3200.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2025, 5, 20), 4750.0, SaleStatus.Billed, s3);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2025, 6, 7), 2200.0, SaleStatus.Pending, s8);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2025, 6, 21), 1150.0, SaleStatus.Billed, s4);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2025, 7, 4), 9300.0, SaleStatus.Billed, s6);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2025, 7, 22), 17000.0, SaleStatus.Billed, s7);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2025, 8, 1), 50.0, SaleStatus.Canceled, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2025, 8, 19), 10500.0, SaleStatus.Billed, s2);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2025, 8, 30), 1200.0, SaleStatus.Pending, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2025, 9, 3), 14300.0, SaleStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4, d5, d6);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
