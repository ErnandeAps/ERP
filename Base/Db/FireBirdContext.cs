using Base.Data;
using Microsoft.EntityFrameworkCore;

namespace Base.Db;

public class FireBirdContext:DbContext
{
    public FireBirdContext(DbContextOptions<FireBirdContext> options): base(options)
    {
    }
    
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Cliente>(en =>
        {
            en.ToTable("CLIENTE");
            en.HasKey(e => e.ID_CADASTRO);
        });
        
        modelBuilder.Entity<Fornecedor>(en =>
        {
            en.ToTable("FORNECEDOR");
            en.HasKey(e => e.ID_CADASTRO);
        });
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder
            .UseFirebird("Server=localhost;Port:3050;User=SYSDBA;Password=masterkey;Database=C:\\Program Files\\Firebird\\Firebird_3_0\\TESTE.FDB");
    }
}