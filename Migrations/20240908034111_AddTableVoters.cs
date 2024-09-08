using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurePoll_BE.Migrations
{
    /// <inheritdoc />
    public partial class AddTableVoters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "voters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    election_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_voters_elections_election_id",
                        column: x => x.election_id,
                        principalTable: "elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_voters_users_user_id",
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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Micheal1@yahoo.com", "599822134", "Grimes", "Fay", "Concepcion.Barton11", "NbL0cTnlKc", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Karlie.Casper92@yahoo.com", "809221627", "Thompson", "Gillian", "Jaime_OReilly", "Td5Vl5St0V", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Molly.Carter@hotmail.com", "622406537", "Rodriguez", "Armand", null, "1mEYQ2sCt6", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Jillian87@hotmail.com", "918265483", "Cartwright", "Madelynn", "Collin.King49", "VkYuhSSRzL", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Krystina32@gmail.com", "580471999", "Stark", "Daphnee", "Kacey57", "0qIj2RsZ1I", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Santino_Maggio@gmail.com", "878908918", "Olson", "Kellie", "Jessica26", "zX7RIoM2Wj" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Frederick18@yahoo.com", "922285114", "Luettgen", "Willie", "o7sQZ9AhJX" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Domenick.Smitham34@gmail.com", "385267121", "Beahan", "Lillian", "Carroll.Robel99", "bWomGCo5TK" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Tara.Waters88@yahoo.com", "646988258", "Walter", "Anastacio", "Alexys10", "6vL5FFph50", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Keyon.OConnell21@gmail.com", "668935253", "Schoen", "Timothy", "Cora_Cronin", "BqtIuIVbfl" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 5, "Bonnie_Cummings56@yahoo.com", "244142997", "Cartwright", "Solon", "fweP4pYcHm" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Lilyan_Kling61@yahoo.com", "761122531", "Ortiz", "Maxine", null, "y9uVSLe_AP", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Genesis_Raynor43@hotmail.com", "000327573", "Koch", "Mackenzie", "Arvel_Dooley95", "sjn3hlXl2m" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Colton.Pouros@gmail.com", "196953953", "Simonis", "Hardy", "Katrine_Armstrong2", "jXHidQhly2" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Shanny70@gmail.com", "337048796", "Bruen", "Marilie", null, "5sTNIR6FZf" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Gussie.Gibson@hotmail.com", "456123174", "Reichert", "Vida", "Zander.Miller", "N9IuLYhCzy", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Henderson.Yundt@gmail.com", "972710364", "Walker", "Phoebe", null, "CcExwLnGSX", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Cecilia_Schmidt@yahoo.com", "283864119", "Farrell", "Lilly", "GiATaOuICR", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Mohammed.Bednar@yahoo.com", "734458570", "Kiehn", "Damian", null, "PKiQrbyREY", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Allen_Ebert@hotmail.com", "916401757", "Mayer", "Imani", "Raul.Weber", "sQZfEUiio2", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Abelardo_Nitzsche@yahoo.com", "649383216", "Moore", "Marge", "Jamil_Kautzer", "g6sFUa1q4y", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Deborah32@gmail.com", "112883898", "Champlin", "Joyce", "6r2BfInfr_", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Judson.Terry@yahoo.com", "043469066", "Shields", "Mason", "Nathanael_Larkin", "_X4uBf4Npv", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Kaela98@gmail.com", "763521622", "Wisozk", "Ricky", null, "kt8t3daf__" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Nikolas.Rodriguez@hotmail.com", "091189302", "Corwin", "Alfonso", "KYcJH_eqeE", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Darryl_Runolfsson31@hotmail.com", "537100326", "Johnson", "Camila", "Camila.Paucek", "uufpSK1pMk", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Werner38@hotmail.com", "828812573", "Ferry", "Koby", "Jordane88", "EUdQuPVhv5" });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Kianna.Klein@yahoo.com", "364148867", "Parisian", "D'angelo", null, "EDWISZ2O_y", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Mara5@gmail.com", "007903008", "Jacobi", "Callie", "MW7nlV7tDq" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Madeline98@yahoo.com", "758932601", "Schmeler", "Vernon", "V5CT4eitjv" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Dallas_Hackett@yahoo.com", "832545345", "Lang", "Aric", null, "GHpOMsC6PQ", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Ricky3@hotmail.com", "508629826", "Koepp", "Jaquelin", "Susanna.Reinger", "elQs4XbweA" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Shanel_Vandervort7@gmail.com", "660946998", "Schmeler", "Dominique", null, "nPf2NVkPKA", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Mario_Stehr@yahoo.com", "866908484", "Goldner", "Roel", "Gerson.Streich86", "fG2ujVPC5q", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { "Amira.Kessler32@gmail.com", "585636099", "Harris", "Crystel", "TREBMYpBXc" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Bert_Goyette@yahoo.com", "607124687", "Leannon", "Kelly", null, "_YAcegLsxO", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Raina.Christiansen@hotmail.com", "058055085", "Gibson", "Garnet", "NHB_D0MtJ3" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Alexie.Gerhold@yahoo.com", "651958408", "Moore", "Annamae", "Emma.Kuhn54", "R1wyLmbETp", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Wyman_Gutmann12@gmail.com", "369712485", "Wyman", "Nestor", null, "jrYv5WHLL0" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Charlie_Olson@hotmail.com", "962732197", "Schuster", "Chadrick", "TpeF7EHHaU", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Jada55@hotmail.com", "212120467", "Hintz", "Tierra", "xdGmb9C3w5", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Terrance_Crona@yahoo.com", "143114701", "Beier", "Newton", "Zoila36", "FFTTbqNFv4", 3 });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Cecile_Weissnat@gmail.com", "330052034", "Reynolds", "Karley", "Abbey_Schroeder80", "psHDJj9_qb" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Margot_Grady@hotmail.com", "440883128", "Larkin", "Millie", "Margot.Gutkowski", "X6p_Y88kJA", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Jarrell.Armstrong31@yahoo.com", "051584955", "Price", "Gerardo", "Sister_Funk70", "grH_tiYWmi", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Aileen66@hotmail.com", "056529848", "Nader", "Abby", "QrawAxpJpb" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Amya.Upton4@gmail.com", "995450474", "McGlynn", "Herman", "Franco.Collier82", "ehxPAPBMZX" });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Therese71@gmail.com", "670358757", "Witting", "Terrance", null, "S5Cm71Hjy7" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Willard_Jakubowski@hotmail.com", "152208912", "Schuster", "Tristin", "Ole_Lubowitz", "VBllEo91CQ", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Mose.Bartell30@gmail.com", "203214003", "Waelchi", "Benjamin", "Hellen_Streich", "aS368p0ZcZ", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Lucas88@yahoo.com", "191531528", "Moen", "John", "Edd_Marquardt", "9hfAphRD3m" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Paula20@yahoo.com", "857149808", "Monahan", "Clemens", "Kasey89", "8FLG9Jmqak" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Mabelle_Kreiger50@hotmail.com", "885788510", "Goyette", "Kyle", "E3PSjZ3qXv", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Obie9@hotmail.com", "233056209", "Spencer", "Leone", null, "KymGsKQGLu" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Lily_Walker46@gmail.com", "530361650", "McGlynn", "Dedrick", "Edwina.Zieme51", "JdrZDcl551", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Carmel25@gmail.com", "203449188", "Fahey", "Elisa", "Catharine84", "gVCwz_IYeW" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Jadyn.Connelly@hotmail.com", "843854242", "Mann", "Abdullah", "Kathlyn_Mayer", "jOSTB1gHyY", 2 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Nicklaus.Mayer77@gmail.com", "272405406", "Auer", "Maurice", null, "j2lLsbwdeR", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Gabrielle.Borer73@hotmail.com", "143535177", "Weissnat", "Coralie", "Antonina.Hilpert56", "F0oJnMveVp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Conrad_Gerlach@yahoo.com", "725582179", "Ankunding", "Candelario", null, "W6PXlS55Rk", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Rhiannon_OHara97@yahoo.com", "243232498", "Maggio", "Jaylen", "Bryana_Rath", "zgZ_ISyWq8" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Ethelyn36@gmail.com", "016029776", "Koelpin", "Raphaelle", "Mya.Champlin", "GSYHD7B_6U", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Jessyca95@gmail.com", "357199363", "Gutkowski", "Lydia", "Jettie.Dickinson11", "mc_313pdJV", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Leland30@hotmail.com", "563408795", "Grimes", "Larry", "pTZShECdRp" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Nyah_Beahan91@yahoo.com", "574696984", "Jakubowski", "Jaeden", null, "Rdlrj3hG5s", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Vida.Lehner84@gmail.com", "304042060", "Casper", "Afton", "OG3rJF70sT" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Vincenza.Torp@hotmail.com", "721518805", "Daniel", "Hailee", "Janie_Stroman96", "J2E39yJzFS", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 5, "Sharon.Dooley82@hotmail.com", "228759424", "VonRueden", "Jeff", "Un7fbVktMo" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Juanita.Konopelski34@yahoo.com", "212669944", "Mayert", "Minerva", "Barton82", "rkcEbnbZ9N", 2 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Harry.Orn@gmail.com", "733780284", "Abernathy", "Lonny", null, "bcSSPRTyCQ", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Nora64@hotmail.com", "844686636", "Fahey", "Mozelle", "Francisco95", "dNRi5VH_xV", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Wilton_Hills@yahoo.com", "371786639", "Rolfson", "Isac", "Moshe_Price91", "0H2rzeKMUF", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_voters_election_id",
                table: "voters",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "IX_voters_user_id",
                table: "voters",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "voters");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Rachelle33@hotmail.com", "715853730", "Breitenberg", "Lelia", "Jaclyn.Ullrich", "j9eWiQKoBP", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Jonatan_McKenzie91@gmail.com", "065099499", "Breitenberg", "Sabryna", null, "Js1vAoAXdt", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Marcella87@yahoo.com", "635939139", "Legros", "Danika", "Mary75", "u7lpkaEaJ0" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Wallace.OConnell23@hotmail.com", "595937923", "Bergstrom", "Pinkie", "Antonio.Hilll", "9v5ToMIXqB", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Edythe.Strosin87@hotmail.com", "186934588", "Schuppe", "Francesco", "Heber13", "DvQIZUzyrc", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Marvin_VonRueden41@hotmail.com", "711057528", "Smitham", "Dallin", null, "sufrdOTSfw", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Estefania.Oberbrunner@yahoo.com", "080106059", "Kozey", "Athena", "Michelle.McClure43", "w8dvKvJc_x", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Raleigh.Ruecker68@yahoo.com", "369088617", "Hartmann", "Oren", null, "mXmqbZCqag" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Amira42@gmail.com", "030512242", "Stamm", "Kyle", null, "rWA4j_Rt_j", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Charity26@yahoo.com", "990735594", "Oberbrunner", "Ernestine", "56PlEuUebj" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Odell91@hotmail.com", "515988603", "Kunde", "Alexis", "Dayna_Bernier", "RxvnnHx3jv" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Kelsi64@yahoo.com", "551610998", "Champlin", "Justice", null, "lQo7v2casD", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Furman35@yahoo.com", "977732410", "Effertz", "Hudson", null, "y43tzwAYFL" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Audrey.Feest@yahoo.com", "460252262", "Parker", "Armani", "MHHPQH3MKM" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Antoinette92@yahoo.com", "630691784", "Willms", "Shane", "Adrian.Ferry89", "3e9QIFFbcE", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Ofelia.Lockman28@hotmail.com", "526335193", "Hayes", "Meda", null, "0dOiBhLQpg" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Jennyfer46@yahoo.com", "076330705", "Stroman", "Cora", null, "sLusgVlqVf" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Kennedy.Hilll@yahoo.com", "377746482", "Luettgen", "Astrid", "Gloria_Lubowitz", "JqUQ0epTWA" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Xander_Schmitt8@gmail.com", "748006878", "Harber", "Henriette", null, "dF0XYiT9OT", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Alexis_Lueilwitz95@yahoo.com", "465522198", "Nolan", "Jeramy", "_LoM0B0QYA", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Name11@yahoo.com", "578417846", "Kutch", "Trudie", null, "AF0tU9i5nh", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Kyra_Schumm18@yahoo.com", "505630537", "Williamson", "Rahul", "Elva_Fahey", "QDmcv6Eixb", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Karlie.Schmitt49@yahoo.com", "906070430", "Ward", "Ericka", "jzOJ0bZW7z", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Vivian.Bode@gmail.com", "164206501", "Rodriguez", "Broderick", "Keshawn_Osinski47", "xe1EJDtPzi", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Lia.Erdman@gmail.com", "990076881", "Howell", "Roselyn", null, "Ufo_RloheN", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Marlen55@yahoo.com", "953491615", "Dicki", "Santiago", null, "m7msZH_8J_", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Warren9@hotmail.com", "905709832", "Hane", "Emilie", "TTM0J3w1Bc", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Alfredo.Hettinger86@hotmail.com", "061099520", "Wisozk", "Ophelia", "44DR0SnDTe", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Kyra_Dickens@gmail.com", "457898340", "Schneider", "Lillie", "Chet.Bashirian", "a_bmBMmRoJ", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Amina.Zboncak@gmail.com", "650483541", "Witting", "Cale", "Macie.Wisoky47", "cRuXDG19gs" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Andreane_Feest@hotmail.com", "554468391", "Howell", "Delphine", "4cMcaObuGq", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Chester_Kessler@gmail.com", "226568027", "Rogahn", "Mariela", null, "aPReJXwpJB", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Opal.Howell@hotmail.com", "285067914", "Buckridge", "Libby", "Drake.Bailey", "W90_0zi2Z9" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Aileen.Dooley85@gmail.com", "666073334", "Kassulke", "Aylin", "Eunice_Hand53", "gaYCEE3d1K", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Petra8@yahoo.com", "962789279", "Ferry", "Alanis", "Makenzie_Stamm57", "oxg6rlzklJ", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Clifford_Beer@hotmail.com", "736140594", "Rath", "Mervin", "6w2HritmQI" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Devonte_Schaden94@gmail.com", "199444014", "Collins", "Leo", null, "NnFyvs09C9", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Grayson.Schimmel@yahoo.com", "352138109", "Schaden", "Giuseppe", "bEswfSS7GL" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Crystel93@gmail.com", "846405424", "Friesen", "Kyleigh", "Leilani.Cole", "j836dOx0Z_", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Abby.Buckridge@hotmail.com", "766065553", "Spencer", "Leopold", "Rowland59", "5CurRZpKX3", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Claud_Murazik@gmail.com", "123027761", "Pfannerstill", "Markus", "Sim.Gaylord29", "PGne4SKDRh" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Laurence74@yahoo.com", "593729447", "Nicolas", "Jameson", null, "6_1QO0tE8r", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Jeffery_Waelchi@yahoo.com", "013251062", "Schmidt", "Tierra", "Freida.Pfeffer", "qXq1hxqbaC", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Albert.Will4@hotmail.com", "508410799", "Bayer", "Johnnie", null, "dPcSyooq0P", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { "Madge28@yahoo.com", "565272903", "Moore", "Lazaro", "yJf2aUOnYz" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Kathryne.Ledner@gmail.com", "009207131", "Jacobson", "Cortney", "pXiOOyAzOr", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Eliza_Runolfsson2@yahoo.com", "365203217", "Cartwright", "Veda", "ZFWw1b7SR7", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Angela51@gmail.com", "608168184", "Gulgowski", "Mavis", "Jaycee.Bernier", "3qgd0tRnnL", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Daniela.Stoltenberg@gmail.com", "398495438", "Schuppe", "Janae", "2uMdxRDXLy" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Eda_Kihn@hotmail.com", "379729624", "Wunsch", "Cecil", null, "v4CspFKUf_", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Jennifer2@gmail.com", "345590159", "Corwin", "Dylan", "Will_Greenholt98", "vlAyxsXcpa" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Adelle90@gmail.com", "354054096", "Jacobi", "Garth", "BlV0D8VskI", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Dedrick53@yahoo.com", "089443014", "Ferry", "Scot", "Keeley39", "lXqVexQc9F", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Eliza.Schumm43@yahoo.com", "631995040", "Willms", "Germaine", "IMKDF7RiXZ", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Marjolaine_Denesik98@hotmail.com", "921153563", "Mann", "Marianne", null, "osNF3X5MeA", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Kayden76@yahoo.com", "526574273", "Ortiz", "Jasmin", null, "fTj9jzXykA" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Patience55@gmail.com", "246847162", "Weimann", "Haley", "A53lsIZuNh", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Herman.Reichel@yahoo.com", "468356119", "Leuschke", "Kane", null, "BdgiXNWtBd" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Dana_Goldner@yahoo.com", "785860956", "O'Keefe", "Dennis", null, "DqYk5J8AlS", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Lucie.Zulauf59@yahoo.com", "242069377", "Johns", "April", "Myrtie12", "QceXtZexKp", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Ella31@hotmail.com", "926591878", "Hansen", "Lindsey", null, "w_Kjuur5O1", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Mertie_Stoltenberg73@gmail.com", "763999707", "Bruen", "Arch", "AxowQq34S3" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Filomena.Pfeffer34@yahoo.com", "731951760", "Lang", "Kenny", null, "RH8TIaGvwb", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Devyn.Schoen@hotmail.com", "176987421", "Wilderman", "Carolyn", "vqqomSiu_R", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Rosendo_Goldner43@gmail.com", "646300762", "Cummings", "Justine", "Reta82", "aWTwj_oLGW", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Eugene92@gmail.com", "373370964", "Shields", "Mia", "Yvonne_Graham", "nk5ExS8wsZ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Nora10@hotmail.com", "922547143", "Russel", "Libby", "Kaleigh.Roberts68", "MkhfYZW91R" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Gaston_Kirlin@yahoo.com", "301146767", "Smith", "Edwin", "Wilton.Gulgowski", "JxSKsOt1f_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Carmine_Cormier1@gmail.com", "427671697", "Rempel", "Juana", null, "zTbuf4R9s0", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Kory48@yahoo.com", "721528089", "Reichert", "Lia", "Kadin.Sauer50", "GRGwN0ADQ_", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Noemi.Roberts72@hotmail.com", "186385219", "Russel", "Jane", "Soledad.Dickinson2", "JSVhw0uJrW" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Bernard71@yahoo.com", "567599231", "Orn", "Lucie", null, "rg31fmY0KI" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Maya54@gmail.com", "533215857", "Ziemann", "Ursula", "n6uwVLJrdG", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Nicholas12@hotmail.com", "931215244", "Nitzsche", "Hayley", "Margarete39", "0A9xTFXCvj" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Hannah.Feest77@hotmail.com", "068960475", "Dibbert", "Jabari", "Garrison_Wilkinson", "hNPOOZ3lKd", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Katelynn_Romaguera75@hotmail.com", "022651879", "Hahn", "Vince", null, "4KaCCf8D_8" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Sanford.McDermott62@gmail.com", "249692159", "Kreiger", "Alexandre", "Darron.Cummerata85", "IeYh6tvBYw", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Josiah_Kihn70@hotmail.com", "307611078", "Koss", "Zaria", "SxDVirCebK", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Kiel.Koelpin@gmail.com", "766959398", "Harris", "Jacinto", "Sabina_Anderson31", "zKDtUuBxFD", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Rahsaan.Kunde90@hotmail.com", "267270544", "Hirthe", "Marcus", null, "rqdWeTaEvp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Karson60@gmail.com", "199423753", "Monahan", "Reece", "Laisha47", "PkjoX4g2rv" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Precious_Kub@gmail.com", "176696496", "Fadel", "Mikayla", "Sydnie.Lemke92", "IjGEiJ0Xu6", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Mallie.Labadie83@hotmail.com", "497426795", "Thompson", "Corbin", "Orie61", "4wINKrGnXW" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Idell_Lind@hotmail.com", "575526022", "Harvey", "Emelia", null, "n5GPc31D0Q", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Piper61@hotmail.com", "111977358", "Rogahn", "Deontae", "Earnest_Gibson", "zFGpRR5fxp", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Alf_Kunze@hotmail.com", "602792185", "Conroy", "Ralph", "RMlG_mYrJH" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Ayden.Zemlak@hotmail.com", "892262148", "Glover", "Devante", null, "O0YseEh_MU", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Federico.Okuneva27@yahoo.com", "095893547", "Ankunding", "Tressie", "Cristian_Deckow89", "Je8CFY3sbC", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Pearl_Wunsch@hotmail.com", "336984880", "Collier", "Vidal", "Edwina_Osinski", "yvuw6vVL7K", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Dortha.Orn@gmail.com", "885408490", "Hegmann", "Meda", "RpVRpvKth7" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Yadira_Goodwin@yahoo.com", "329442057", "Emard", "Royal", "Mary.Mertz", "9pkvbDSsWu", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Dayna95@hotmail.com", "762058977", "Friesen", "Irma", null, "D5qbp1jQAH", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Marquis99@gmail.com", "950372731", "Moore", "Richard", "UXWcJYIWI_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Delilah93@hotmail.com", "911527027", "Raynor", "Yadira", "Elisa.Grimes91", "dw8SjyLE7L", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Erwin.Morar@yahoo.com", "392526646", "Schroeder", "Maymie", null, "Oo_PdqyowP" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Dovie_Berge@hotmail.com", "906637883", "MacGyver", "Fausto", "Rosalind_Macejkovic", "w_TdbZD9nq", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Ansley55@yahoo.com", "806836860", "Tromp", "Phoebe", "Adrain_Gleichner67", "djMii43QAJ", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Geovanni_Abshire@gmail.com", "048543306", "Gaylord", "Keira", "Hilbert19", "RbN7y5WA_6" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Zaria91@hotmail.com", "236379958", "Grimes", "Sabryna", "Summer.Murphy", "Pt8G_Fd4q_", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Olaf85@yahoo.com", "489260627", "Runte", "Leonardo", null, "pcP9QjiGIB", 4 });
        }
    }
}
