using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecurePoll_BE.Models;

[Table("elections")]
public class Election
{
    [Key]
    public int Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }

    [Column("start_date")] 
    public DateTime StartDate { get; set; }

    [Column("end_date")] 
    public DateTime EndDate { get; set; }

    [Column("owner_id")]  
    public int OwnerId { get; set; }

    //Navigation Properties
    [ForeignKey("OwnerId")]
    public virtual User? Owner { get; set; }
}
