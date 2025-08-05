using ClinicApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    
   public DbSet<Usuario> Usuarios { get; set; }
   public DbSet<Cliente> Clientes { get; set; }
   public DbSet<Agendamento> Agendamentos { get; set; }
   public DbSet<Status> Status { get; set; }
   public DbSet<Titulo> Titulo { get; set; }
   public DbSet<Procedimento> Procedimentos { get; set; }
   
   public DbSet<RelatorioConsulta> RelatoriosConsultas { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       modelBuilder.Entity<Agendamento>(entity =>
       {
           entity.HasKey(e => e.Id);
           entity.Property(e => e.Id)
               .ValueGeneratedOnAdd(); // Isso indica que o Id é gerado no banco
       });
   }

}