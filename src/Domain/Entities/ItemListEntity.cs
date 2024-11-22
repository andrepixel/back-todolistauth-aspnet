using System.ComponentModel.DataAnnotations.Schema;

class ItemListEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public required String Name { get; set; }
    public required String Description { get; set; }
    public required ListEntity List { get; set; }
    public DateTime CreatedAt { get; set; }
}