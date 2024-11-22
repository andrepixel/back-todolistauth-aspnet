using Microsoft.EntityFrameworkCore;

class ItemListRepository : IItemListRepository
{
    private readonly AppDbContext context;

    public ItemListRepository(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<ItemListEntity?> CreateItem(ItemListEntity itemListEntity)
    {
        var entityEntry = await context.Items.AddAsync(itemListEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<ItemListEntity?> DeleteItemById(ItemListEntity itemListEntity)
    {
        var entityEntry = context.Items.Remove(itemListEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<List<ItemListEntity>?> GetAllItens()
    {
        return await context.Items.ToListAsync();
    }

    public async Task<ItemListEntity?> GetItemById(Guid id)
    {
        return await context.Items.FindAsync(id);
    }

    public async Task<ItemListEntity?> UpdateItem(ItemListEntity itemListEntity)
    {
        var entityEntry = context.Items.Update(itemListEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }
}