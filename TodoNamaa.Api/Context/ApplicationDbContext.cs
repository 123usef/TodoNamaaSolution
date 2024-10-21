using Microsoft.EntityFrameworkCore;
using TodoNamaa.Api.Models;

namespace TodoNamaa.Api.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        
        }

        //with the Connection 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.   ("Data Source=.;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //Fluent Api 
            //Todo Fluent Api 
            //modelBuilder.Entity<Todo>()
            //    .Property(t => t.Name)
            //    .IsRequired()
            //    .HasMaxLength(50);
            //modelBuilder.Entity<Todo>().
            //    Property(t => t.Description)
            //    .IsRequired(false);

            //modelBuilder.Entity<Todo>()
            //    .HasOne<Category>(t => t.Category)
            //    .WithMany(p => p.Todo)
            //    .HasForeignKey(t=>t.CatId);
                

        }


        public DbSet<Todo> todos    { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
