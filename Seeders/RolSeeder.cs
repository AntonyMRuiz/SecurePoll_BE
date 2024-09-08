using Microsoft.EntityFrameworkCore;
using SecurePoll_BE.Models;

namespace SecurePoll_BE.Seeders;

public static class RolSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rol>().HasData(
            new Rol { Id = 1, Name = "Administrador" },
            new Rol { Id = 2, Name = "Cliente" },
            new Rol { Id = 3, Name = "Votante" },
            new Rol { Id = 4, Name = "Candidato" }
        );
    }
}
