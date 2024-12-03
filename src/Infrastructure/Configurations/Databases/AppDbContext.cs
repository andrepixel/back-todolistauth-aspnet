using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    // public DbSet<UserEntity> Users { get; set; }
    public DbSet<ItemListEntity> Itens { get; set; }
    public DbSet<ListEntity> Lists { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
    {
        dbContextOptionsBuilder.UseSqlServer();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<ListEntity>()
        .HasMany(list => list.Itens)
        .WithOne(item => item.List)
        .HasForeignKey(item => item.List);
    }
}