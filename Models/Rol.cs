using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecurePoll_BE.Models
{
    [Table("roles")]
    public class Rol
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }
    }
}
