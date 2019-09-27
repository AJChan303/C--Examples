using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapStoneTrial.Models {
    public class PRSDB :DbContext {
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public PRSDB(DbContextOptions options) : base(options) {

        }
    }
}
