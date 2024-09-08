using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurePoll_BE.Migrations
{
    /// <inheritdoc />
    public partial class AddTableCandidates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    election_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_candidates_elections_election_id",
                        column: x => x.election_id,
                        principalTable: "elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_candidates_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Chance74@hotmail.com", "700442683", "Sipes", "Kadin", "Claud_Klocko61", "lt2MbrzSZe", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Malika_Doyle28@hotmail.com", "922344586", "Johns", "Dena", "Ben57", "dc_oTqkAXt" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Kiana_Hammes@yahoo.com", "843827070", "Abernathy", "Alan", "Opal44", "9i4d_ffBkK" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Misty.Toy@gmail.com", "698964737", "Schmeler", "Rhianna", "WRk9AFweAB", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Freeman_Kohler6@yahoo.com", "202055940", "Deckow", "Lizeth", "Woodrow.Braun", "DtdxgBDs63", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Arlo79@yahoo.com", "460474398", "Harris", "Hassie", "Dudley.Veum86", "eKOijp9TgH", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Emelia_Cole@gmail.com", "449651857", "Conn", "Mckenzie", null, "75tKY9EDmR", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Rahul_Tremblay5@gmail.com", "281183628", "Collins", "Haven", null, "8xAQcYwmbI", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Tiara_Roberts35@hotmail.com", "055415376", "Sporer", "Abdul", null, "i11chJaTOF", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Leonard55@hotmail.com", "005493632", "Gerhold", "London", "Leonardo58", "IiiiMlfFzy", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Evan_Kutch@gmail.com", "122500061", "Schuppe", "Lorenz", "Dariana_Strosin", "DwlrBKCEr_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Moises61@yahoo.com", "375009676", "Stark", "Ulises", "Luis_Tillman6", "5KnvCeZKQn", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Dustin.Denesik87@yahoo.com", "780261886", "Hudson", "Solon", "London93", "CCaqj7IIYc", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Marjory40@yahoo.com", "410029364", "Jacobs", "Lee", "Yr3DG29fh6", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Elmore98@yahoo.com", "656503967", "Reilly", "Domingo", "Judah_Pacocha50", "tulNJY6Ymk", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Fred_Flatley96@yahoo.com", "431129633", "Stroman", "Makenna", null, "PNnGup1JWd", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Ryley.Mosciski3@yahoo.com", "474326099", "McClure", "Crawford", "Zaria.Schroeder", "wGR72EJAv3", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Laney_Murphy@gmail.com", "490040884", "Zboncak", "Wilburn", "tYfHlbLL1B", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Catalina.Lowe@yahoo.com", "721202850", "Marks", "Lucile", "Liliana59", "JMS4VF9jC2", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Lonny_Yost10@yahoo.com", "499580598", "Cruickshank", "Lionel", "B608EBWn1C", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Jake43@hotmail.com", "698674895", "Fritsch", "Lois", null, "sUayLDhZlr" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Lia65@gmail.com", "416404615", "Ziemann", "Roy", "8BIUUTbzPl", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Gia_King87@yahoo.com", "965134928", "Parisian", "Blanca", "Brice14", "kXDYJmhtCa", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 5, "Tyrique62@yahoo.com", "479155114", "McKenzie", "Johnny", "R3stwoTRsG" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Earnest14@hotmail.com", "979889693", "Rice", "Anastasia", "Mavis.Murray74", "WE7x8ly86z" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Gene_Mann@hotmail.com", "350314438", "Nolan", "Jayden", null, "G8YdUIqahB" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Roberto_Beatty@gmail.com", "996452688", "Bins", "Ernesto", "HDPzCzgR13" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Carlo.Ankunding@yahoo.com", "952836417", "Senger", "Timothy", "9jT3xBY7U2", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Kyla.Mann@yahoo.com", "431671394", "Mayert", "Enoch", "Karlee_Cremin", "cVL0BuOvJq" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Marcelle_Schuster@yahoo.com", "673476401", "Sanford", "Syble", "Lacey_Doyle", "GsDIfP42tr", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Mortimer38@yahoo.com", "642079414", "Rosenbaum", "Elsie", "04X5eFgK2s", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Nathaniel49@yahoo.com", "765719183", "Kihn", "Billy", null, "CB2jP5rixp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Cassie.Waters44@yahoo.com", "671753462", "Reilly", "Maria", "Anika_Rempel", "EAYFY5F5S6" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Graciela.Kulas2@hotmail.com", "599775684", "Murazik", "Franco", null, "d6Vv7m73n5", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "May63@hotmail.com", "821793131", "Hoppe", "Tyrique", "Donna.Jacobi", "FqxeFHu3P_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Bertram.Krajcik93@yahoo.com", "279831530", "Gleason", "Belle", "Edmond.Sanford", "FzBWQJ9dUn", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Susanna.Langosh6@gmail.com", "210104785", "Keeling", "Meta", "Tommie79", "NHLEri7YrZ", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Raheem69@gmail.com", "611758152", "Legros", "Danyka", "nggJWrTpfB", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Orville_Kris7@hotmail.com", "218621725", "Tremblay", "Wiley", "r7Cr6fBJ9y", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Alanna65@gmail.com", "297952148", "Carroll", "David", null, "87IA_zDPcJ", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Luisa.Konopelski@yahoo.com", "466810133", "Heller", "Nayeli", "Nico_Skiles42", "hO8xNls_mP", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Mohammad24@gmail.com", "897417596", "Hammes", "Stefanie", null, "WLETRyM4PU", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Noel10@yahoo.com", "391419118", "Dare", "Ephraim", "0ACRoRsYnA", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Milan_Emard@hotmail.com", "351029537", "Krajcik", "Etha", "Marshall.Christiansen90", "vGdmnwMktI" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Destinee_Goyette@yahoo.com", "130430330", "Lang", "Constantin", "Krystal.Schumm3", "9XL4qwzJF6", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Mireille_DAmore7@gmail.com", "630463437", "Gottlieb", "Jayson", "YpepI5rS8f", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Annetta12@hotmail.com", "511164465", "Sauer", "Antonina", "gp88GtRVEX", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Bertram9@yahoo.com", "470474625", "Schmidt", "Destini", "Valentin_Parisian", "VcOQBTvMD7" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Audra_Schuster@yahoo.com", "349942922", "Hills", "Shanna", "i8AoPaFiye", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Alverta80@yahoo.com", "734904766", "Wisoky", "Edward", "Dave.Cassin61", "QcfA9WyMdA" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Annie_Sawayn36@hotmail.com", "207304332", "Beier", "Dejah", "Floy_Tromp", "ukj_sP7yIB", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Ariane_Spinka@gmail.com", "682121109", "Smith", "Lura", "Chelsie.Ward31", "kcoSoPBlRQ", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Bella_Upton@yahoo.com", "019991836", "Marquardt", "Johnathan", "Osbaldo.Rolfson", "2qpzKGhMnz", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Otis_Treutel32@yahoo.com", "952809583", "Haag", "Alayna", "Mose_Schaden41", "tg5FYaPxF5" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Gloria_Raynor@hotmail.com", "368651725", "Hagenes", "Jeff", null, "zkkWOOk3Ts" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Mitchell.Goldner@hotmail.com", "807106732", "Goyette", "Marjory", "Jeffry_Huels", "pSfg8omLFo" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Fern_DAmore79@yahoo.com", "012324003", "Anderson", "Alford", "_7oV6a5Fdo", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Damaris_Hansen64@yahoo.com", "649572332", "Mosciski", "Hassie", "Webster59", "YjNbQUc1SJ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Justen68@gmail.com", "327871687", "Lehner", "Letitia", "Maximilian_Auer12", "d1_0vxHq6W", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Mauricio.Kiehn10@yahoo.com", "458071754", "Emard", "Ludwig", null, "i51ATt4_jo" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Oliver_Turner@gmail.com", "036163613", "Halvorson", "Kristofer", null, "sR6QLvuSVT", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Madge_Stokes@yahoo.com", "791473909", "Wehner", "Coby", "kRJHIcL2mv", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Pansy.Halvorson1@hotmail.com", "544525315", "Padberg", "Else", null, "nw6W9CjkuU", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Frankie56@hotmail.com", "660318405", "Schoen", "Janessa", "twWMg3gIml", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Chloe46@hotmail.com", "816245172", "Nitzsche", "Tessie", "Shayna_Crooks39", "9sbnROTFxO", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Kendrick91@hotmail.com", "597182602", "Tromp", "Maverick", "Carmine_Schuppe", "0LGFNkKQRl", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Cayla.Walker@gmail.com", "127020157", "Labadie", "Leopoldo", "Jane_McDermott13", "yPmOz8MsES" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Mara58@yahoo.com", "529068708", "Collins", "Delphia", "Cicero_Wilderman87", "eMyIED2mFd" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Anahi98@gmail.com", "878704263", "Shields", "Ruby", "Oswaldo.Nikolaus", "bWEe3NxueD" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Elsa_Blick@yahoo.com", "405318185", "Reilly", "Owen", "Reinhold_Conn", "S0wxgqc3xx", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Diana.Kuhic90@hotmail.com", "348249903", "Effertz", "Reina", null, "yzXBUU8qPR", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Audra89@hotmail.com", "173519699", "Parisian", "Nayeli", null, "i2i4frDvpV", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Hunter_Hudson@yahoo.com", "192480646", "Marvin", "Eleonore", "2i7mdwh9YA" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Bryon_Price40@yahoo.com", "105892468", "Veum", "Alfred", "pgGmhVCvse", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Caesar_Toy@gmail.com", "403937676", "Raynor", "Celine", "Arthur_Kuhlman55", "oSOk_nXq2E" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Pete64@yahoo.com", "775917730", "Blick", "Garrett", null, "fqhQQc2jB_", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Jarrod_Crooks@hotmail.com", "701169099", "Hyatt", "Madilyn", null, "Fbqdzr9BNr", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Mallie.Lemke73@gmail.com", "725952948", "Johns", "Oral", "D2SyOo_e2R", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Ilene85@gmail.com", "765288960", "Grimes", "Presley", "Alvera_Haley25", "l8JDSSDbmr" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Nolan46@gmail.com", "030342516", "Jerde", "Dee", "Lambert_Legros", "1bGf2r1hYY" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Kendra_Metz@gmail.com", "256640022", "Renner", "Jessica", null, "JjBlsMZSmu", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Garrick.Schmitt@gmail.com", "920192956", "Gibson", "Karelle", "ydAIoA_WtK", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Izabella.Hintz7@hotmail.com", "517547330", "Bins", "Erich", null, "2rdi3rPjYa", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Joany.Zboncak28@yahoo.com", "102057892", "Douglas", "Hector", "Cullen.Grimes", "1bLQ_W34V4", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Gretchen.Cummerata@hotmail.com", "206370644", "Abbott", "Nicolas", null, "WHzAFHmpW2" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Winifred_Mills@hotmail.com", "158075436", "Bahringer", "Lawrence", "Kelvin_Cummings", "X9JaMF346S", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Keyon96@gmail.com", "495126389", "Fay", "Bernadette", null, "pL_gGMUTqV", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Brando_Lind@gmail.com", "110094625", "Wilderman", "Maia", "bQkHQIJksF", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Bonnie41@yahoo.com", "782196124", "Jacobs", "Marian", "Nicolas.Mayert", "W3H_JoZbf6", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Louisa_Gaylord@yahoo.com", "431167237", "Reichert", "Alyce", "Gussie.OConner36", "xTykfwzn62" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Hiram_Klocko38@gmail.com", "760087060", "Runte", "Amira", "Linwood.Rohan83", "4axbFypBel", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Leo_Legros@gmail.com", "634811846", "Reichel", "Serena", "Frankie14", "SGzQPMu_w0" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Ari_Harber@hotmail.com", "764298108", "Hodkiewicz", "Zack", "hD4wj9Rp9M", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Elvis_McKenzie@gmail.com", "647943060", "Will", "Antonetta", "Ansley25", "LMXpe6igCz" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Drake_Parker84@hotmail.com", "770849342", "Stehr", "Mark", "Abbigail22", "07gOzI51Hl" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Ivory18@gmail.com", "081370625", "Rempel", "Wava", "Shawn_Conroy", "KSqTsDbjl1", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Rosalia43@gmail.com", "639610618", "Legros", "Jade", "Abigale_Blick16", "l4sQPNTIdN" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Rhiannon_Anderson@gmail.com", "016562463", "Daugherty", "Jessyca", "Ladarius.OHara88", "5RSD531Siy" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Noble_Ullrich@gmail.com", "815394296", "Greenholt", "Buster", null, "xIE6LIP5H3", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Berry5@hotmail.com", "786899412", "Walter", "Leonora", "Elfrieda17", "rOwxKQh0qn", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_candidates_election_id",
                table: "candidates",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_user_id",
                table: "candidates",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidates");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Micheal1@yahoo.com", "599822134", "Grimes", "Fay", "Concepcion.Barton11", "NbL0cTnlKc", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Karlie.Casper92@yahoo.com", "809221627", "Thompson", "Gillian", "Jaime_OReilly", "Td5Vl5St0V" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Donnie81@hotmail.com", "032362458", "Bins", "Seth", "Beulah84", "Vr0YgeDPXQ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Molly.Carter@hotmail.com", "622406537", "Rodriguez", "Armand", "1mEYQ2sCt6", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Jillian87@hotmail.com", "918265483", "Cartwright", "Madelynn", "Collin.King49", "VkYuhSSRzL", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Krystina32@gmail.com", "580471999", "Stark", "Daphnee", "Kacey57", "0qIj2RsZ1I", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Devonte24@yahoo.com", "252704470", "Bednar", "Constance", "Gregg.Hyatt", "gExXRSbvlG", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Santino_Maggio@gmail.com", "878908918", "Olson", "Kellie", "Jessica26", "zX7RIoM2Wj", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Lorena95@gmail.com", "235115971", "Beer", "Marcel", "Hallie.Murphy", "y6as2B8qS5", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Frederick18@yahoo.com", "922285114", "Luettgen", "Willie", null, "o7sQZ9AhJX", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Domenick.Smitham34@gmail.com", "385267121", "Beahan", "Lillian", "Carroll.Robel99", "bWomGCo5TK" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Tara.Waters88@yahoo.com", "646988258", "Walter", "Anastacio", "Alexys10", "6vL5FFph50", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Keyon.OConnell21@gmail.com", "668935253", "Schoen", "Timothy", "Cora_Cronin", "BqtIuIVbfl", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Bonnie_Cummings56@yahoo.com", "244142997", "Cartwright", "Solon", "fweP4pYcHm", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Lilyan_Kling61@yahoo.com", "761122531", "Ortiz", "Maxine", null, "y9uVSLe_AP", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Genesis_Raynor43@hotmail.com", "000327573", "Koch", "Mackenzie", "Arvel_Dooley95", "sjn3hlXl2m", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Colton.Pouros@gmail.com", "196953953", "Simonis", "Hardy", "Katrine_Armstrong2", "jXHidQhly2", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Shanny70@gmail.com", "337048796", "Bruen", "Marilie", "5sTNIR6FZf", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Aimee.Kulas@yahoo.com", "772324909", "Schiller", "Veda", "Dexter.Bechtelar87", "anmhRYGgvL", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Cornelius12@hotmail.com", "698433787", "Grant", "Kane", "faZXdLjuk2", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Gussie.Gibson@hotmail.com", "456123174", "Reichert", "Vida", "Zander.Miller", "N9IuLYhCzy" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Henderson.Yundt@gmail.com", "972710364", "Walker", "Phoebe", "CcExwLnGSX", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Cecilia_Schmidt@yahoo.com", "283864119", "Farrell", "Lilly", null, "GiATaOuICR", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Mohammed.Bednar@yahoo.com", "734458570", "Kiehn", "Damian", "PKiQrbyREY" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Allen_Ebert@hotmail.com", "916401757", "Mayer", "Imani", "Raul.Weber", "sQZfEUiio2" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Abelardo_Nitzsche@yahoo.com", "649383216", "Moore", "Marge", "Jamil_Kautzer", "g6sFUa1q4y" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Deborah32@gmail.com", "112883898", "Champlin", "Joyce", "6r2BfInfr_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "April_Hand@gmail.com", "499395055", "Powlowski", "Lesly", "vFbuIsazXo", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Judson.Terry@yahoo.com", "043469066", "Shields", "Mason", "Nathanael_Larkin", "_X4uBf4Npv" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Kaela98@gmail.com", "763521622", "Wisozk", "Ricky", null, "kt8t3daf__", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Nikolas.Rodriguez@hotmail.com", "091189302", "Corwin", "Alfonso", "KYcJH_eqeE", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Darryl_Runolfsson31@hotmail.com", "537100326", "Johnson", "Camila", "Camila.Paucek", "uufpSK1pMk" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Werner38@hotmail.com", "828812573", "Ferry", "Koby", "Jordane88", "EUdQuPVhv5" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Charity_Ritchie@gmail.com", "355017815", "Weimann", "Elody", "Zack.Swaniawski", "arthKLTjPH", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Kianna.Klein@yahoo.com", "364148867", "Parisian", "D'angelo", null, "EDWISZ2O_y" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Mara5@gmail.com", "007903008", "Jacobi", "Callie", null, "MW7nlV7tDq", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Ambrose.Connelly@hotmail.com", "654395386", "Jacobi", "Mohammed", "Brandy34", "3NNhWFMu_g", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Madeline98@yahoo.com", "758932601", "Schmeler", "Vernon", "V5CT4eitjv", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Dallas_Hackett@yahoo.com", "832545345", "Lang", "Aric", "GHpOMsC6PQ", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Emely77@hotmail.com", "088239488", "Lubowitz", "Randi", "Cristobal.Sipes9", "qO8ztEaxJs", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Ricky3@hotmail.com", "508629826", "Koepp", "Jaquelin", "Susanna.Reinger", "elQs4XbweA", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Sadie.Schneider@hotmail.com", "047532376", "Hamill", "Katelyn", "Aglae_Gleichner14", "1ZWHM8q3xO", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Shanel_Vandervort7@gmail.com", "660946998", "Schmeler", "Dominique", "nPf2NVkPKA", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Mario_Stehr@yahoo.com", "866908484", "Goldner", "Roel", "Gerson.Streich86", "fG2ujVPC5q" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Amira.Kessler32@gmail.com", "585636099", "Harris", "Crystel", null, "TREBMYpBXc", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Malinda28@yahoo.com", "626910355", "Kassulke", "Ruthe", "G5LiUr4IMO", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Marcelino_Hilll56@gmail.com", "783233892", "Hayes", "Erick", "9duABNP6nE", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Bert_Goyette@yahoo.com", "607124687", "Leannon", "Kelly", null, "_YAcegLsxO" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Raina.Christiansen@hotmail.com", "058055085", "Gibson", "Garnet", "NHB_D0MtJ3", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Alexie.Gerhold@yahoo.com", "651958408", "Moore", "Annamae", "Emma.Kuhn54", "R1wyLmbETp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Wyman_Gutmann12@gmail.com", "369712485", "Wyman", "Nestor", null, "jrYv5WHLL0", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Charlie_Olson@hotmail.com", "962732197", "Schuster", "Chadrick", null, "TpeF7EHHaU", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Luis61@gmail.com", "749649700", "Schaefer", "Boris", null, "P4mnk3F9Za", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Jada55@hotmail.com", "212120467", "Hintz", "Tierra", null, "xdGmb9C3w5" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Terrance_Crona@yahoo.com", "143114701", "Beier", "Newton", "Zoila36", "FFTTbqNFv4" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Susan36@gmail.com", "627331048", "Hodkiewicz", "Buddy", "Elise_Quitzon", "BC7txEiCdX" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Rahsaan.Zemlak28@gmail.com", "494248255", "Schroeder", "Lelia", "LHnVl8M8ri", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Cecile_Weissnat@gmail.com", "330052034", "Reynolds", "Karley", "Abbey_Schroeder80", "psHDJj9_qb" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Renee21@yahoo.com", "034901132", "Deckow", "Marcel", "Ubaldo.Bartoletti", "TA_GtrcYnu", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Margot_Grady@hotmail.com", "440883128", "Larkin", "Millie", "Margot.Gutkowski", "X6p_Y88kJA" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Jarrell.Armstrong31@yahoo.com", "051584955", "Price", "Gerardo", "Sister_Funk70", "grH_tiYWmi", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Aileen66@hotmail.com", "056529848", "Nader", "Abby", "QrawAxpJpb", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Titus.Parisian@gmail.com", "233123545", "Johnston", "Tod", "Abner.Stamm", "1X_yL7xyn8", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Shea_Mann92@yahoo.com", "214823790", "Harvey", "Israel", "cfgYom1Mxx", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Delfina_Emard49@yahoo.com", "673266220", "Murazik", "Ibrahim", null, "BySg3KJKPc", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Amya.Upton4@gmail.com", "995450474", "McGlynn", "Herman", "Franco.Collier82", "ehxPAPBMZX", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Jazmyn.Morissette@hotmail.com", "089713751", "Hane", "Aurore", "Sammie66", "cpPVNsBBRT" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Therese71@gmail.com", "670358757", "Witting", "Terrance", null, "S5Cm71Hjy7" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Willard_Jakubowski@hotmail.com", "152208912", "Schuster", "Tristin", "Ole_Lubowitz", "VBllEo91CQ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Mose.Bartell30@gmail.com", "203214003", "Waelchi", "Benjamin", "Hellen_Streich", "aS368p0ZcZ", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Lucas88@yahoo.com", "191531528", "Moen", "John", "Edd_Marquardt", "9hfAphRD3m", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Paula20@yahoo.com", "857149808", "Monahan", "Clemens", "Kasey89", "8FLG9Jmqak", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Mabelle_Kreiger50@hotmail.com", "885788510", "Goyette", "Kyle", "E3PSjZ3qXv" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Obie9@hotmail.com", "233056209", "Spencer", "Leone", "KymGsKQGLu", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Lily_Walker46@gmail.com", "530361650", "McGlynn", "Dedrick", "Edwina.Zieme51", "JdrZDcl551" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Carmel25@gmail.com", "203449188", "Fahey", "Elisa", "Catharine84", "gVCwz_IYeW", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Jadyn.Connelly@hotmail.com", "843854242", "Mann", "Abdullah", "Kathlyn_Mayer", "jOSTB1gHyY", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Camylle_Harris13@yahoo.com", "030475057", "Predovic", "Fatima", "KQJdEstP0B", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Nicklaus.Mayer77@gmail.com", "272405406", "Auer", "Maurice", null, "j2lLsbwdeR" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Sibyl_Hoppe48@gmail.com", "425182859", "Cremin", "Paolo", "River_Erdman30", "YVFVdL4_wW" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Gabrielle.Borer73@hotmail.com", "143535177", "Weissnat", "Coralie", "Antonina.Hilpert56", "F0oJnMveVp", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Conrad_Gerlach@yahoo.com", "725582179", "Ankunding", "Candelario", "W6PXlS55Rk", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Rhiannon_OHara97@yahoo.com", "243232498", "Maggio", "Jaylen", "Bryana_Rath", "zgZ_ISyWq8", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Ethelyn36@gmail.com", "016029776", "Koelpin", "Raphaelle", "Mya.Champlin", "GSYHD7B_6U", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Jessyca95@gmail.com", "357199363", "Gutkowski", "Lydia", "Jettie.Dickinson11", "mc_313pdJV" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Leland30@hotmail.com", "563408795", "Grimes", "Larry", null, "pTZShECdRp", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Piper94@gmail.com", "187472985", "Fisher", "Aileen", "Steve_Altenwerth57", "2h4ovoHHL5", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Nyah_Beahan91@yahoo.com", "574696984", "Jakubowski", "Jaeden", "Rdlrj3hG5s", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Newton13@yahoo.com", "191241238", "Streich", "Zula", "Theodore.Schultz", "MdkaULe4mo", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Vida.Lehner84@gmail.com", "304042060", "Casper", "Afton", null, "OG3rJF70sT" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Alivia.Bednar@yahoo.com", "548452981", "Auer", "Luna", "Diana70", "24ntqdCY4G", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Vincenza.Torp@hotmail.com", "721518805", "Daniel", "Hailee", "Janie_Stroman96", "J2E39yJzFS" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Sharon.Dooley82@hotmail.com", "228759424", "VonRueden", "Jeff", "Un7fbVktMo", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Juanita.Konopelski34@yahoo.com", "212669944", "Mayert", "Minerva", "Barton82", "rkcEbnbZ9N" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Raven_Bartell@gmail.com", "751643117", "Pfannerstill", "Michel", "Porter_Dare3", "8GSPBbWImL" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Katheryn.Reichert@gmail.com", "067491560", "Flatley", "Leann", null, "4UZxJJjwmn", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Harry.Orn@gmail.com", "733780284", "Abernathy", "Lonny", null, "bcSSPRTyCQ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Rashawn40@gmail.com", "719815623", "Streich", "Cale", "Hailee50", "MUeINJ9sOX" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Nora64@hotmail.com", "844686636", "Fahey", "Mozelle", "Francisco95", "dNRi5VH_xV", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Wilton_Hills@yahoo.com", "371786639", "Rolfson", "Isac", "Moshe_Price91", "0H2rzeKMUF", 2 });
        }
    }
}
