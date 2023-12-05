using Microsoft.EntityFrameworkCore;
using Re.Core.Models;

#nullable disable

namespace Re.Data;


public class DataContext : DbContext
{
    public DbSet<Patient> Patients { get; set; } 
    
    public DataContext() {}
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    { } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    { 
        if (!optionsBuilder.IsConfigured) 
        { 
            optionsBuilder.UseNpgsql("UserID=postgres;Password=passmein123;Server=localhost;Port=5432;Database=reanim;"); 
        } 
    }

    //Протоколы
    public DbSet<StandardProtocol> Protocols { get; set; }
    public DbSet<SLRProtocol> SLRProtocols { get; set; }
    public DbSet<CentralVeinProtocol> CentralVeinProtocols { get; set; }
    public DbSet<ArteriaProtocol> ArteriaProtocols { get; set; }
}