using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.DataModels;
using System.Configuration;

namespace EntityFramework
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
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["EntityAtos"];
           
            string retorno = "";

            if(settings != null)
                retorno =  settings.ConnectionString;
           
            optionsBuilder.UseSqlServer(retorno);
            optionsBuilder.UseLazyLoadingProxies(); 
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
