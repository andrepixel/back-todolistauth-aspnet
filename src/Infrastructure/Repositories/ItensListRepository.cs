using Microsoft.EntityFrameworkCore;

class ItensListRepository : IItensListRepository
{
    private readonly AppDbContext context;

    public ItensListRepository(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<ItemListEntity?> CreateItemList(ItemListEntity itemListEntity)
    {
        var entityEntry = await context.Itens.AddAsync(itemListEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<List<ItemListEntity>?> GetAllItensList()
    {
        return await context.Itens.ToListAsync();
    }

    public async Task<ItemListEntity?> FindItemListById(Guid id)
    {
        return await context.Itens.FindAsync(id);
    }

    public async Task<ItemListEntity?> UpdateItemList(ItemListEntity itemListEntity)
    {
        var entityEntry = context.Itens.Update(itemListEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<ItemListEntity?> DeleteItemList(ItemListEntity itemListEntity)
    {
        var entityEntry = context.Itens.Remove(itemListEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }
}