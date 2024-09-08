using Microsoft.EntityFrameworkCore;
using SecurePoll_BE.Models;

namespace SecurePoll_BE.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<DocumentType> DocumentType { get; set; } = default!;
    public DbSet<Rol> Roles { get; set; } = default!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    
}
