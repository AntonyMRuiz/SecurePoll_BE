using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecurePoll_BE.Models;

[Table("users")]
public class User
{
    [Key]
    public int Id { get; set; }

    [Column("name")]
    public required string Name { get; set; }

    [Column("last_name")]
    public required string LastName { get; set; }

    [Column("document_type_id")]
    public int DocumentTypeId { get; set; }

    [Column("identification_number")]
    public required string IdentificationNumber { get; set; }

    [Column("public_key")]
    public string? PublicKey { get; set; }

    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("oauth_google")]
    public string? OauthGoogle { get; set; }

    [ForeignKey("DocumentTypeId")]
    public virtual DocumentType? DocumentType { get; set; }

    [ForeignKey("RoleId")]
    public virtual Rol? Role { get; set; }
}
