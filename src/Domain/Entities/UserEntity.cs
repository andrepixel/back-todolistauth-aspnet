using System.ComponentModel.DataAnnotations.Schema;

public class UserEntity(Guid id, string name, string email, string password, bool isVip, DateTime createdAt)
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } = id;

    public required String Name { get; set; } = name;

    public required String Email { get; set; } = email;

    public required String Password { get; set; } = password;

    public Boolean IsVip { get; set; } = isVip;

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; } = createdAt;
}