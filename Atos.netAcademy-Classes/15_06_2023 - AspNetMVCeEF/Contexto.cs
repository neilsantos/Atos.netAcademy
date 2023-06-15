using AspNetMVCeEF.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetMVCeEF
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = CodeFistMvc; User ID = USUARIO; password = NEILSANTOS; language = Portuguese; trusted_connection = true; encrypt = false;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(e => e.Emails)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}