using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<ItemListEntity> Items { get; set; }
    public DbSet<ListEntity> Lists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
    {
        dbContextOptionsBuilder.UseSqlServer();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemListEntity>()
        .HasOne(list => list.List)
        .WithMany(list => list.Itens);
    }

}