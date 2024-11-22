using System.ComponentModel.DataAnnotations.Schema;

class UserEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public required String Name { get; set; }
    public required String Email { get; set; }
    public required String Password { get; set; }
    public Boolean IsVip { get; set; }
    public DateTime CreatedAt { get; set; }
}