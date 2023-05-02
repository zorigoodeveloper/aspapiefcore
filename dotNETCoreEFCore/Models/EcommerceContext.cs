using Microsoft.EntityFrameworkCore;

namespace dotNETCoreEFCore.Models
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext()
        {
        }

        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=db_ecommerce;Trusted_Connection=True;User Id=sa;Password=123;TrustServerCertificate=true;");
    }
}
