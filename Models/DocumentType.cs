using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecurePoll_BE.Models;

[Table("document_types")]
public class DocumentType
{
    [Key]
    public int Id { get; set; }

    [Column("name")]
    public required string Name { get; set; }

    [Column("abbreviation")]
    public required string Abbreviation { get; set; }
}
