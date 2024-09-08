using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurePoll_BE.Migrations
{
    /// <inheritdoc />
    public partial class AddTableElections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "elections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    start_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    owner_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_elections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_elections_users_owner_id",
                        column: x => x.owner_id,
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
                values: new object[] { 6, "Rachelle33@hotmail.com", "715853730", "Breitenberg", "Lelia", "Jaclyn.Ullrich", "j9eWiQKoBP", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Jonatan_McKenzie91@gmail.com", "065099499", "Breitenberg", "Sabryna", "Js1vAoAXdt", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Marcella87@yahoo.com", "635939139", "Legros", "Danika", "Mary75", "u7lpkaEaJ0", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Wallace.OConnell23@hotmail.com", "595937923", "Bergstrom", "Pinkie", "Antonio.Hilll", "9v5ToMIXqB" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Edythe.Strosin87@hotmail.com", "186934588", "Schuppe", "Francesco", "Heber13", "DvQIZUzyrc" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Marvin_VonRueden41@hotmail.com", "711057528", "Smitham", "Dallin", "sufrdOTSfw", 3 });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Raleigh.Ruecker68@yahoo.com", "369088617", "Hartmann", "Oren", "mXmqbZCqag", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Amira42@gmail.com", "030512242", "Stamm", "Kyle", null, "rWA4j_Rt_j" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Charity26@yahoo.com", "990735594", "Oberbrunner", "Ernestine", "56PlEuUebj", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Odell91@hotmail.com", "515988603", "Kunde", "Alexis", "Dayna_Bernier", "RxvnnHx3jv", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Kelsi64@yahoo.com", "551610998", "Champlin", "Justice", "lQo7v2casD" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Furman35@yahoo.com", "977732410", "Effertz", "Hudson", "y43tzwAYFL", 2 });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Ofelia.Lockman28@hotmail.com", "526335193", "Hayes", "Meda", null, "0dOiBhLQpg" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Jennyfer46@yahoo.com", "076330705", "Stroman", "Cora", null, "sLusgVlqVf", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Xander_Schmitt8@gmail.com", "748006878", "Harber", "Henriette", "dF0XYiT9OT" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Alexis_Lueilwitz95@yahoo.com", "465522198", "Nolan", "Jeramy", null, "_LoM0B0QYA", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Name11@yahoo.com", "578417846", "Kutch", "Trudie", "AF0tU9i5nh" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Kyra_Schumm18@yahoo.com", "505630537", "Williamson", "Rahul", "Elva_Fahey", "QDmcv6Eixb", 2 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Lia.Erdman@gmail.com", "990076881", "Howell", "Roselyn", "Ufo_RloheN" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Marlen55@yahoo.com", "953491615", "Dicki", "Santiago", "m7msZH_8J_", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 1, "Warren9@hotmail.com", "905709832", "Hane", "Emilie", "TTM0J3w1Bc" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Alfredo.Hettinger86@hotmail.com", "061099520", "Wisozk", "Ophelia", null, "44DR0SnDTe" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Amina.Zboncak@gmail.com", "650483541", "Witting", "Cale", "Macie.Wisoky47", "cRuXDG19gs", 2 });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Chester_Kessler@gmail.com", "226568027", "Rogahn", "Mariela", null, "aPReJXwpJB", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Opal.Howell@hotmail.com", "285067914", "Buckridge", "Libby", "Drake.Bailey", "W90_0zi2Z9", 3 });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { "Clifford_Beer@hotmail.com", "736140594", "Rath", "Mervin", "6w2HritmQI" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Devonte_Schaden94@gmail.com", "199444014", "Collins", "Leo", null, "NnFyvs09C9" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Grayson.Schimmel@yahoo.com", "352138109", "Schaden", "Giuseppe", "bEswfSS7GL", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Crystel93@gmail.com", "846405424", "Friesen", "Kyleigh", "Leilani.Cole", "j836dOx0Z_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Abby.Buckridge@hotmail.com", "766065553", "Spencer", "Leopold", "Rowland59", "5CurRZpKX3", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Laurence74@yahoo.com", "593729447", "Nicolas", "Jameson", "6_1QO0tE8r", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Jeffery_Waelchi@yahoo.com", "013251062", "Schmidt", "Tierra", "Freida.Pfeffer", "qXq1hxqbaC" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Albert.Will4@hotmail.com", "508410799", "Bayer", "Johnnie", "dPcSyooq0P", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 5, "Madge28@yahoo.com", "565272903", "Moore", "Lazaro", "yJf2aUOnYz" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Eliza_Runolfsson2@yahoo.com", "365203217", "Cartwright", "Veda", null, "ZFWw1b7SR7", 2 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Daniela.Stoltenberg@gmail.com", "398495438", "Schuppe", "Janae", null, "2uMdxRDXLy", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Eda_Kihn@hotmail.com", "379729624", "Wunsch", "Cecil", "v4CspFKUf_", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Jennifer2@gmail.com", "345590159", "Corwin", "Dylan", "Will_Greenholt98", "vlAyxsXcpa", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Adelle90@gmail.com", "354054096", "Jacobi", "Garth", "BlV0D8VskI", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Eliza.Schumm43@yahoo.com", "631995040", "Willms", "Germaine", null, "IMKDF7RiXZ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Marjolaine_Denesik98@hotmail.com", "921153563", "Mann", "Marianne", "osNF3X5MeA", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Kayden76@yahoo.com", "526574273", "Ortiz", "Jasmin", "fTj9jzXykA" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Patience55@gmail.com", "246847162", "Weimann", "Haley", null, "A53lsIZuNh", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Herman.Reichel@yahoo.com", "468356119", "Leuschke", "Kane", null, "BdgiXNWtBd" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Dana_Goldner@yahoo.com", "785860956", "O'Keefe", "Dennis", null, "DqYk5J8AlS", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Ella31@hotmail.com", "926591878", "Hansen", "Lindsey", null, "w_Kjuur5O1" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Mertie_Stoltenberg73@gmail.com", "763999707", "Bruen", "Arch", null, "AxowQq34S3", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Filomena.Pfeffer34@yahoo.com", "731951760", "Lang", "Kenny", "RH8TIaGvwb", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Devyn.Schoen@hotmail.com", "176987421", "Wilderman", "Carolyn", null, "vqqomSiu_R", 2 });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Gaston_Kirlin@yahoo.com", "301146767", "Smith", "Edwin", "Wilton.Gulgowski", "JxSKsOt1f_", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Carmine_Cormier1@gmail.com", "427671697", "Rempel", "Juana", "zTbuf4R9s0" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Maya54@gmail.com", "533215857", "Ziemann", "Ursula", "n6uwVLJrdG", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Nicholas12@hotmail.com", "931215244", "Nitzsche", "Hayley", "Margarete39", "0A9xTFXCvj", 2 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Katelynn_Romaguera75@hotmail.com", "022651879", "Hahn", "Vince", null, "4KaCCf8D_8", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Sanford.McDermott62@gmail.com", "249692159", "Kreiger", "Alexandre", "Darron.Cummerata85", "IeYh6tvBYw" });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Kiel.Koelpin@gmail.com", "766959398", "Harris", "Jacinto", "Sabina_Anderson31", "zKDtUuBxFD", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Rahsaan.Kunde90@hotmail.com", "267270544", "Hirthe", "Marcus", "rqdWeTaEvp", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Mallie.Labadie83@hotmail.com", "497426795", "Thompson", "Corbin", "Orie61", "4wINKrGnXW", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Idell_Lind@hotmail.com", "575526022", "Harvey", "Emelia", "n5GPc31D0Q" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Piper61@hotmail.com", "111977358", "Rogahn", "Deontae", "Earnest_Gibson", "zFGpRR5fxp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Alf_Kunze@hotmail.com", "602792185", "Conroy", "Ralph", "RMlG_mYrJH", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Federico.Okuneva27@yahoo.com", "095893547", "Ankunding", "Tressie", "Cristian_Deckow89", "Je8CFY3sbC" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Pearl_Wunsch@hotmail.com", "336984880", "Collier", "Vidal", "Edwina_Osinski", "yvuw6vVL7K" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Dortha.Orn@gmail.com", "885408490", "Hegmann", "Meda", "RpVRpvKth7", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Dayna95@hotmail.com", "762058977", "Friesen", "Irma", "D5qbp1jQAH", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Marquis99@gmail.com", "950372731", "Moore", "Richard", null, "UXWcJYIWI_", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Delilah93@hotmail.com", "911527027", "Raynor", "Yadira", "Elisa.Grimes91", "dw8SjyLE7L" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Erwin.Morar@yahoo.com", "392526646", "Schroeder", "Maymie", "Oo_PdqyowP", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Olaf85@yahoo.com", "489260627", "Runte", "Leonardo", null, "pcP9QjiGIB", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_elections_owner_id",
                table: "elections",
                column: "owner_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "elections");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Adolf_Shanahan@yahoo.com", "925139522", "Deckow", "Muhammad", "Sydnie.Kuvalis63", "2TSeBOVHpu", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Cullen_Batz70@yahoo.com", "799881569", "Dickens", "Elaina", "L8hMWPLa31", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Mustafa.Metz@gmail.com", "078203246", "Green", "Myrna", "Patsy.Reilly", "2_qXzUalmG", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Gloria_Reinger33@hotmail.com", "261650713", "Oberbrunner", "Genevieve", "Weston.Bode", "1LsZInFH5X" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Evie91@yahoo.com", "792382682", "Smith", "Maxwell", "Ismael97", "5FGILiCx6C" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Letitia_Padberg76@yahoo.com", "176674915", "Bartoletti", "Desiree", "E4mDaYsMsc", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Norris_Zieme@hotmail.com", "214191679", "Lueilwitz", "Beth", "Alden40", "ciDW5Ub7o7", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Kaitlin.Lemke@hotmail.com", "137320966", "Koepp", "Anastacio", "_qZ11mUDtH", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Damian_Gerlach89@hotmail.com", "403221265", "Fritsch", "Madeline", "Jude66", "1TwenccyVW" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Carissa98@hotmail.com", "663109671", "Krajcik", "Camilla", "zOwti66ctH", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Cleora67@yahoo.com", "439070940", "Glover", "Geo", "Beaulah50", "bsyXNx08Sh", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 1, "Destin.Fritsch99@hotmail.com", "548557003", "Reichert", "Alf", "8Bl6KHd3ud" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Patsy.Walsh@gmail.com", "704069577", "Botsford", "Deshaun", "QEmRADtNa2", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 5, "Dee.OKon26@hotmail.com", "954799228", "Gaylord", "Raymond", "IhJjJcNbep" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Hermina91@hotmail.com", "705478814", "Wiza", "Frances", "Davonte7", "PuEaTv4sZz", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Johathan58@hotmail.com", "605947461", "Gleichner", "Patrick", "Judd_Funk", "BFy3Y3N1We" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Beaulah.Ratke@yahoo.com", "535369155", "Yost", "Jedediah", "Jerald_Fay56", "ze8ObRUL7M", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Amina_Haley83@yahoo.com", "127713960", "Ebert", "Florine", "Tyrese93", "jOQ5kQOF1q" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Zelda.Pfeffer5@hotmail.com", "841613964", "Larson", "Mohamed", "n4JdNnHUoK" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Constantin19@gmail.com", "692021107", "Hickle", "Magali", "Jamal50", "Py9DVQsS51", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 5, "Stacey43@hotmail.com", "007190606", "Wolf", "Joe", "gpX0rIPxaF" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Dejon.Weissnat79@yahoo.com", "253089238", "Oberbrunner", "Jason", "Ericka_Turner67", "sEKlOMxqN4", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Marquis2@gmail.com", "228765665", "Larson", "Laurine", "1Miiv3DnBT", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Lulu.Bosco@hotmail.com", "109673216", "Stanton", "Joshuah", null, "N1gzqJ_DHy", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Maximillia.Wisoky51@gmail.com", "734367722", "Langworth", "Samir", "4NxgGgSp42" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Mandy80@yahoo.com", "392489396", "Mann", "Garrett", "3teT2Cbkj8", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Robb.Veum25@hotmail.com", "397235061", "Reichel", "Bartholome", "XEdN96jy8b" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Giovanna_OConner@yahoo.com", "206573449", "Johnson", "Felton", "Lucious_Steuber", "tWf7t3iUNV" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Gunnar64@yahoo.com", "740874930", "Ferry", "Lauretta", "Garth_Hansen41", "uQwRcJiYZo", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Aidan_McDermott33@hotmail.com", "349797731", "Lockman", "Lenore", null, "F_HHijCS8B", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Hoyt_Grimes49@yahoo.com", "934158602", "Franecki", "George", "UtjlKUNFs_", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Connie.Hartmann@hotmail.com", "239760050", "Leannon", "Sherwood", "Jessica_Ratke", "M7lLnS7hGD", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Christina86@hotmail.com", "183105228", "Schamberger", "Lura", null, "HWQPS4r6QE", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Lucinda99@hotmail.com", "634736338", "Heaney", "Clair", "Kelsi.Pouros59", "IinoyNylJg", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Dena_Hoeger37@hotmail.com", "531471693", "Predovic", "Isom", "Patsy.Parisian34", "YGo9q9qe5C", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { "Clement_Grimes27@gmail.com", "182176486", "Batz", "Isaac", "jDXDF0Y72G" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Jadon.Streich@hotmail.com", "193863843", "Stehr", "Keven", "Celine_Cormier49", "qPh1donEZf" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Electa_Kulas@yahoo.com", "730499113", "Homenick", "Myriam", "qiKcOrNUyL", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Kurt21@yahoo.com", "354013526", "Trantow", "Rickey", null, "fkxB24_5g7" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Edgardo_Borer50@hotmail.com", "104196641", "Auer", "Sierra", "Alfred.Leuschke", "JBiJzZzRI7", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Quentin_Bartoletti@gmail.com", "889075280", "Kilback", "Marquis", null, "EtZpl2xI7g" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Kenya.Jakubowski25@gmail.com", "591877560", "Rowe", "Kris", "tQoYIyJ08_", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Oscar_Kuvalis48@gmail.com", "908110841", "Windler", "Adrien", "Johnpaul.Muller47", "p2R9yNmgp0" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Juvenal.Lehner@gmail.com", "686969799", "Kuvalis", "Crawford", "NXwsO0rTBE", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Einar.Purdy@hotmail.com", "877623946", "Bode", "Berniece", "Zt3g5a9Zw3" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Oda43@hotmail.com", "167160546", "Hahn", "Colten", "fQOZzrK2e0", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Zaria.Von28@hotmail.com", "619718410", "Nitzsche", "Mireya", "Liliane72", "fR8Yis29ZH", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Dominique81@gmail.com", "595697141", "Grimes", "Nelson", "Clay64", "tZmlFknui_", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Gino_Homenick@yahoo.com", "845703403", "Pfannerstill", "Electa", "Fred94", "XicxfoUMn_", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Misael97@gmail.com", "775288086", "O'Kon", "Dovie", "BK246q5agF", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Omari41@hotmail.com", "586563104", "Jerde", "Carolyn", null, "nx0GXR53Zo", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Mariela_Johns85@yahoo.com", "487023908", "Gorczany", "Dovie", "OQzprCcNYv", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Deion.Grant@hotmail.com", "245016421", "Boyer", "Ilene", "Miracle82", "y7mtlWrImd", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Nicklaus.Pacocha@hotmail.com", "870161033", "Tillman", "Donnie", "Kailee.Muller47", "loPnCOHDc1" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Krystel18@gmail.com", "964429439", "O'Connell", "Ciara", "hUggLxr5iH", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Felipe_Hodkiewicz62@hotmail.com", "736345989", "Dicki", "Quentin", "I2p2qnT9g_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Tod_Cassin@hotmail.com", "879848182", "Keebler", "Keshawn", "Reinhold.Romaguera", "P_oTDE0zWj", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Alexandra.Bauch@gmail.com", "080576463", "Hermiston", "Brenden", "Donny_Weber", "r2RKjiUMaS" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Rupert_Bartoletti28@yahoo.com", "083023451", "Effertz", "Jaren", "Duncan.Zboncak", "bneEy5P1rM", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Malachi_Dickinson87@gmail.com", "762550834", "Hickle", "Kelley", "Winfield_Zieme", "hHlMu13Hhy", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Alanna.Greenfelder@yahoo.com", "219652433", "Langosh", "Candida", "Kendra.Daugherty", "Umb58q5sbK" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Elena80@gmail.com", "719008521", "Stamm", "Eladio", "Mack_Kuphal", "YYD3qEv8eu", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Jerald57@hotmail.com", "638783975", "Heidenreich", "Austyn", "MQmRlKIPga", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Henderson42@gmail.com", "672883798", "Witting", "Margarita", "Maximilian.Lakin", "q5L8u4r_KX", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Gordon.Von@yahoo.com", "800717637", "Bauch", "Carlotta", "Carlie.Sanford76", "0Jp2zsn_zr", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Sarai_Beier@yahoo.com", "797362976", "Gaylord", "Rhoda", "Mellie.Kuphal90", "5CO_P5SSR1" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Arne.Block13@gmail.com", "792495285", "Glover", "Thelma", "Spencer11", "YqWfmm0ztT" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Connor.Koelpin66@hotmail.com", "288962783", "Robel", "Arnaldo", null, "oQr9uIktlh", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Trystan75@hotmail.com", "351828141", "Kuphal", "Stephanie", "Hf6rraiI2t" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Clemmie_Padberg82@yahoo.com", "892326323", "Mitchell", "Macy", null, "rRgkIoBw_Y", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Lyda94@yahoo.com", "842615262", "Kozey", "Reggie", null, "aXElFFG3Pe" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Reid_Monahan97@gmail.com", "982267695", "Wiza", "Myrtis", "Zita29", "r2x0xRlUkN" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Nico65@gmail.com", "200164459", "Kautzer", "Scarlett", "RjhkU3yVYc", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Mollie_Littel@hotmail.com", "783088538", "Rohan", "Louvenia", null, "bYfmZBSfz3", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Jeanette41@hotmail.com", "165571320", "Wintheiser", "Justus", null, "mzaeUCV0zi", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Madison72@hotmail.com", "349852702", "Dietrich", "Heloise", "Lia_Collins46", "o8FQ_jsn4l", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Tavares_Pouros45@hotmail.com", "402482906", "Homenick", "Gladyce", null, "F4FsIOUgkQ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Eunice_Nolan@hotmail.com", "073278130", "Towne", "Mireya", "f1cgdDm1ev", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Kennedi65@yahoo.com", "072800553", "Hyatt", "Ozella", "Malcolm71", "JjaYjLroEE", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Addison.Douglas25@yahoo.com", "929446194", "Robel", "Sigmund", "q8N5GEs0PN", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Orlando_Glover@gmail.com", "999720719", "Davis", "Hortense", null, "tW4v71G0PZ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Lloyd_McGlynn80@hotmail.com", "481705012", "Ortiz", "Nora", "Francesco82", "lblhuqlKSO", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Samson24@yahoo.com", "662945369", "Walker", "Kenna", null, "gjEK4AdC9B", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Ramon79@hotmail.com", "194360691", "Tromp", "Isabelle", "J3tES3aQpV" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Eldora_Quigley@gmail.com", "199821692", "Jones", "Rhiannon", null, "sClxboF2vT" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Leda_Moen99@hotmail.com", "554233092", "O'Kon", "Brannon", "S1rv2Vhoeu", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Dorcas.Rodriguez@hotmail.com", "301884698", "Jacobs", "Lawson", "Sheridan_Armstrong", "g8fhECHbC_", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Brendon_King@yahoo.com", "092009973", "Russel", "Kevon", "Gussie.Conn17", "dHPbaCKQlM" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Keely_Klein19@yahoo.com", "690777871", "Dicki", "Abraham", null, "E_xc6s83k4" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Jeremy60@yahoo.com", "720536971", "Wolff", "Syble", "4jTCtij_zK", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Destin.Haag88@hotmail.com", "882244743", "Mante", "Amir", "Freeda_Bayer", "3LEFwTFU8W", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Matilde.Lueilwitz27@yahoo.com", "162714698", "Huels", "Jonas", "AahYWLNxFC", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Nicolette61@yahoo.com", "978326755", "Schamberger", "Savanna", "Esteban97", "UON8b1LIN0", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Dangelo.Christiansen@gmail.com", "044379370", "Baumbach", "Marcelle", "Allene.Schimmel", "LENPSJT4k4" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Elwyn17@hotmail.com", "722864633", "Kreiger", "Janis", "j40XgZ7RcR", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Oceane.Paucek@yahoo.com", "718602350", "Vandervort", "Opal", "Teresa.Cruickshank1", "pNfJtA0goo", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Eldon12@gmail.com", "653034579", "Brekke", "Jane", "Marian_Jacobs46", "gUtSHJMkH3", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Mateo10@hotmail.com", "702214277", "Price", "Lolita", "Jerome.Cummings64", "EiDJVJROO0" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Oceane_Blanda@hotmail.com", "037499605", "Wiegand", "Fabian", "Yvonne_Koelpin66", "s9mWyNLI7r", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Yvette71@yahoo.com", "092956977", "Pacocha", "Isaias", "Katlynn18", "iqKyrpSHEm", 3 });
        }
    }
}
