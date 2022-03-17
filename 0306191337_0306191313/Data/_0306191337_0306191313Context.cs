using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DOAN.Models;

namespace _0306191337_0306191313.Data
{
    public class _0306191337_0306191313Context : DbContext
    {
        public _0306191337_0306191313Context (DbContextOptions<_0306191337_0306191313Context> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Product> Products { get; set; }

   
    }
}
