using System.ComponentModel.DataAnnotations.Schema;

class ListEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<ItemListEntity>? Itens { get; set; }
    public DateTime CreatedAt { get; set; }

    public ListEntity(string name, List<ItemListEntity>? itens)
    {
        Name = name;
        Itens = itens;
    }
}