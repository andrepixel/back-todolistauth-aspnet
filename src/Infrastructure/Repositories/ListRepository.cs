using System.Reflection;
using Microsoft.EntityFrameworkCore;

class ListRepository : IListRepository
{
    private readonly AppDbContext context;

    public ListRepository(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<ListEntity?> CreateList(ListEntity listEntity)
    {
        var entityEntry = await context.Lists.AddAsync(listEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<ListEntity?> DeleteListById(ListEntity listEntity)
    {
        var entityEntry = context.Lists.Remove(listEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<List<ListEntity>?> GetAllLists()
    {
        return await context.Lists.ToListAsync();
    }

    public async Task<ListEntity?> FindListById(Guid id)
    {
        return await context.Lists.FindAsync(id);
    }

    public async Task<ListEntity?> UpdateList(ListEntity listEntity)
    {
        var entityEntry = context.Lists.Update(listEntity);

        await context.SaveChangesAsync();

        return entityEntry.Entity;
    }
}