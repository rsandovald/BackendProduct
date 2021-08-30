using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using prEntidades; 

namespace prRepository
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {        
            base.OnModelCreating(modelBuilder);
        }
     

        public DbSet<Category> TB_CATEGORIES
        {
            get; set;
        }

        public DbSet<Product> TB_PRODUCTS
        {
            get; set;
        }

       

    }
}
