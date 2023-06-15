using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ResApi.DataModels;

namespace ResApi
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Pessoa> Email { get; set; }

        public Contexto()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["EntityAtos"];
            string connectionString = "Data Source=localhost; Initial Catalog=CodeFist; User ID=USUARIO; password=NEILSANTOS; language=Portuguese; trusted_connection=true; encrypt=false;";


            //string retorno = "";

            //if(settings != null)
            //    retorno =  settings.ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseLazyLoadingProxies(); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.Pessoa)
                .WithMany(e => e.Emails)
                .OnDelete(DeleteBehavior.ClientCascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
