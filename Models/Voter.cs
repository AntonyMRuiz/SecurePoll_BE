using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecurePoll_BE.Models;

[Table("voters")]
public class Voter
{
    [Key]
    public int Id { get; set; }
    [Column("user_id")]
    public int UserId { get; set; }

    [Column("election_id")]
    public int ElectionId { get; set; }

    [Column("hash")]
    public int Hash { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; }

    [ForeignKey("ElectionId")]
    public Election? Election { get; set; }
}
