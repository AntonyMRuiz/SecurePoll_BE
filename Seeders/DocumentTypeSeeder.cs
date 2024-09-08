using Microsoft.EntityFrameworkCore;
using SecurePoll_BE.Models;

namespace SecurePoll_BE.Seeders;

public class DocumentTypeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DocumentType>().HasData(
            new DocumentType { Id = 1, Name = "Cédula de Ciudadanía", Abbreviation = "CC" },
            new DocumentType { Id = 2, Name = "Tarjeta de Identidad", Abbreviation = "TI" },
            new DocumentType { Id = 3, Name = "Pasaporte", Abbreviation = "PS" },
            new DocumentType { Id = 4, Name = "Número de Identificación Tributaria", Abbreviation = "NIT" },
            new DocumentType { Id = 5, Name = "Cédula de Extranjería", Abbreviation = "CE" },
            new DocumentType { Id = 6, Name = "Registro Civil", Abbreviation = "RC" },
            new DocumentType { Id = 7, Name = "Permiso Especial de Permanencia", Abbreviation = "PEP" }
        );
    }
}
