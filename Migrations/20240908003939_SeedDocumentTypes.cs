using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurePoll_BE.Migrations
{
    /// <inheritdoc />
    public partial class SeedDocumentTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "document_types",
                columns: new[] { "Id", "abbreviation", "name" },
                values: new object[,]
                {
                    { 1, "CC", "Cédula de Ciudadanía" },
                    { 2, "TI", "Tarjeta de Identidad" },
                    { 3, "PS", "Pasaporte" },
                    { 4, "NIT", "Número de Identificación Tributaria" },
                    { 5, "CE", "Cédula de Extranjería" },
                    { 6, "RC", "Registro Civil" },
                    { 7, "PEP", "Permiso Especial de Permanencia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "document_types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "document_types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "document_types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "document_types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "document_types",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "document_types",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "document_types",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
