using Microsoft.EntityFrameworkCore;

namespace SecurePoll_BE.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
