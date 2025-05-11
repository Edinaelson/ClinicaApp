using ClinicApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    
   public DbSet<Usuario> Usuarios { get; set; }
   public DbSet<Cliente> Clientes { get; set; }
   
    
}