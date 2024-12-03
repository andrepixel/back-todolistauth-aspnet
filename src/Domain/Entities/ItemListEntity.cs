using System.ComponentModel.DataAnnotations.Schema;

class ItemListEntity(string name, string description, ListEntity list)
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public string Title { get; set; } = name;

    public string Description { get; set; } = description;

    public ListEntity List { get; set; } = list;

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
}