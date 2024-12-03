using System.ComponentModel.DataAnnotations.Schema;

public class ListEntity(string name, List<ItemListEntity>? itens)
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public string Title { get; set; } = name;

    public List<ItemListEntity>? Itens { get; set; } = itens;

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
}