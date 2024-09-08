using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurePoll_BE.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnHasIntoVoters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "hash_vote",
                table: "voters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Tamia.Reynolds52@gmail.com", "573978560", "Kuhic", "Noemi", "Elena62", "FMWAe_bNCV", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Cleve.Nolan14@hotmail.com", "569984993", "Gusikowski", "Janessa", "0xAUTpY2cY" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Antonio.Crona86@yahoo.com", "068470970", "Kozey", "Delphine", "Mae5", "53PQKe3N7H", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Keaton_DuBuque21@gmail.com", "240194781", "Rutherford", "Aniya", "2C8lSb7z2W" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Asia_Dickinson61@gmail.com", "260887329", "Padberg", "Tiana", "XfhzOD6kKg" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Arvel90@hotmail.com", "309709487", "Stracke", "Mafalda", "Anthony_Glover", "UYFtGExQrZ", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Vernon64@yahoo.com", "260859794", "Feest", "Wellington", "Kiley.Windler23", "hcuL5A3Zwi", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Eli_Heller@yahoo.com", "376448863", "Stokes", "Hillard", "Rebeka15", "ukMGyOpCYe", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Nettie.Johnston@yahoo.com", "095635680", "DuBuque", "Lera", null, "u6a8TAm15d", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Mariah_Heidenreich67@yahoo.com", "272331381", "Dicki", "Noelia", "Lee12", "0mk0_Is8yp", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Tina.Ferry@hotmail.com", "423072201", "Anderson", "Jammie", null, "cq71lRmOUA", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Melyssa42@gmail.com", "191448580", "Green", "Lilian", "Shanon76", "t9iA610xVT", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Stacey34@hotmail.com", "860371617", "Bergstrom", "Dewitt", "Andrew86", "LyDO2lZnFX", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Audie_Jones45@hotmail.com", "950843152", "Windler", "Daisha", "Lon.Morar80", "2G733K1hfm", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Vidal_Kris23@yahoo.com", "328104702", "Kuhlman", "Lavada", "Serenity_Runolfsson47", "sErtuLJzSB" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Jennings.Herman@yahoo.com", "526448034", "McGlynn", "Ryder", "Arianna.Walker", "GCD_7XThtz" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Chaya_Lowe@hotmail.com", "903536559", "Mohr", "Dillan", "Elaina.Conn", "egDr2PLtVB" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Paris48@gmail.com", "544888125", "Bergnaum", "Holly", "Kiley11", "rQZfxE99nI", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Berry_Wilkinson@hotmail.com", "581908205", "Becker", "Bobby", "Lisette67", "UvBJLLd0s8" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Loren_Koch@hotmail.com", "261710618", "Torphy", "Johnpaul", "vXdd_Myrfu", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Sarina94@gmail.com", "748771800", "Hauck", "Easter", null, "2CWAaDEIMz", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Enos_Cremin51@gmail.com", "551287453", "O'Conner", "Gabe", "yYsYqjxx6D", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Laverna_Fisher23@yahoo.com", "087514597", "Waelchi", "Jennifer", "k1BGg1DvSW" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Tavares.Schaden26@gmail.com", "169169233", "Macejkovic", "Stephany", "Ford38", "7Q6xNEsJtp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Madison.Davis@hotmail.com", "367966036", "Hartmann", "Adele", "Eduardo99", "9wEIRPkbeL", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Chelsie_Roberts@gmail.com", "281777422", "Bailey", "Destin", null, "8fYSOe4hnF" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Elwin_Hoppe21@hotmail.com", "126258780", "Borer", "Kareem", "2fFy6YCZ6D", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Tony.Turner@yahoo.com", "267702638", "Spencer", "Billie", "Chance.Streich79", "Re5S61omAG", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Jessie33@yahoo.com", "815270530", "Satterfield", "Geovanny", "ifcAKtM03N", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Jamie5@hotmail.com", "422999581", "Reynolds", "Anahi", null, "75c1n7N52B" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Effie_Bednar@yahoo.com", "930742965", "Sauer", "Abigail", "Norbert.Hilll8", "gDfPRFEOTi", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Olen77@hotmail.com", "591147882", "Jaskolski", "Bert", null, "Yqm3OkstZC", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Eda.Klein@hotmail.com", "280502184", "Ferry", "Jerald", "Eloise.Jakubowski79", "Mul7TPRgtg", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Ryan65@hotmail.com", "427813590", "Mohr", "America", "1yAlqjGm0G", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Justen48@gmail.com", "307518041", "Dach", "Dalton", "Ned_Romaguera", "erQpyR8GXj", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Cristopher_Paucek@gmail.com", "590968773", "Weissnat", "Donnell", "Mara_Hilll", "FixyQoZSon", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Turner.Bergstrom27@hotmail.com", "224319603", "Farrell", "Nicola", "Rasheed29", "BGLyHGCp70", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Archibald_Mayer@hotmail.com", "571792872", "Huels", "Brooks", "Roger_Kiehn89", "tHKLb8v11V", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Elaina23@yahoo.com", "360012285", "Kihn", "Leonard", "Linnea64", "IoW4FmoPwx", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Rachelle.Dibbert@gmail.com", "878657846", "Schaefer", "Reese", null, "Oze6YMY0ZC", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Bianka79@yahoo.com", "250692108", "Reilly", "Milo", null, "SJCBnL731Z" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Diana29@gmail.com", "757047928", "Emmerich", "Eula", "7OsHMVTO1j", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Johathan.Littel@yahoo.com", "700942134", "Schuppe", "Koby", "Edmund_Steuber", "JCYa2lIOLx" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Gillian50@yahoo.com", "548736212", "Quitzon", "Euna", "Junius.Waters", "51scUcqgxv", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Lori88@yahoo.com", "606675903", "Cummerata", "Hilma", "Robb.Aufderhar96", "DdL91qV8FR" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Elwin65@gmail.com", "130216278", "Lueilwitz", "Krista", null, "5B9dpbcvyf", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Rogelio32@gmail.com", "934930298", "Rutherford", "Lisa", null, "x0vrmGDnKa", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Ignatius11@gmail.com", "655220931", "Kshlerin", "Bell", null, "GUTFwA6YDN", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Karen_Nikolaus@gmail.com", "098597212", "Cronin", "Cory", "Adela.Cremin1", "JXihO0YUrI" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Mark_Simonis@yahoo.com", "791440705", "Schimmel", "Clifton", "Allison89", "ubrkWNB7MR", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Adrain.Hane36@gmail.com", "596505562", "Stoltenberg", "Dolores", "UvlINScCoi", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Cory66@gmail.com", "975229760", "Block", "Roselyn", null, "9PKxwe0ixE", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Sidney.Emard@hotmail.com", "584195584", "Rath", "Maegan", "sHAfRapyLx", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Antonia52@hotmail.com", "709953541", "Reynolds", "Kathryne", "Renee65", "DcVgZvege8" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Dominique68@hotmail.com", "356245452", "Kutch", "Florida", "Shakira.Crona9", "H5R8bmHX1K" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Miguel15@hotmail.com", "526375133", "Bauch", "Thad", "Alanis19", "U46ytpqolj" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Alan.Pollich36@hotmail.com", "909196702", "Stehr", "Kyleigh", "Gisselle.Bergnaum70", "ny7CP2_M7y", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Deon_Olson8@gmail.com", "877128718", "Grady", "Claudia", null, "zLCGrr_Jg6", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Reagan_Brown@gmail.com", "891685004", "Lynch", "Judge", "Ansley.Hettinger88", "KEkk9DHE2R", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Tyreek55@hotmail.com", "320152456", "Reichert", "Kellen", null, "a9d1XO5R7f" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Issac.Auer81@gmail.com", "369408883", "Abshire", "Kara", "Cheyanne.Frami24", "blnIuf1TMW", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Kevon_Herzog33@gmail.com", "929872652", "Hettinger", "Scottie", "Nicholas53", "waoLMXxamF", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Estel_Ritchie85@hotmail.com", "688419582", "Roberts", "Molly", null, "3HTBNRyWpD", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Claude.Weimann@hotmail.com", "789065398", "Turcotte", "Justina", null, "VKUo31IXQ6", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Tressa_Schaefer3@hotmail.com", "714854034", "Kassulke", "Sister", "Emelia76", "50nx7d8U5k", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Katelyn.Orn@yahoo.com", "707641487", "Mayert", "Jennie", null, "Fb59Ghu2f4", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Korbin39@yahoo.com", "928362412", "Stamm", "Ardella", null, "xYnIucj21f" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Natasha.Toy67@hotmail.com", "316382895", "Weissnat", "Courtney", null, "SKMqFl2xNW", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Eleazar58@hotmail.com", "704078276", "Collins", "Brown", "Y8NGceT_jp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Lera_Nicolas@gmail.com", "794898582", "Hodkiewicz", "Carley", "Maximo88", "8STHbq6J9g" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Waino_Dickinson86@gmail.com", "378779247", "Armstrong", "Edna", "Ines0", "YKzTjPuaxV" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Hollis29@hotmail.com", "011943354", "Larson", "Santos", "KVanPnv2sc" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Sanford_Kassulke8@gmail.com", "584691614", "Shields", "Mollie", "Corrine_Witting82", "yX3yw0vRna", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Cristian.Connelly@hotmail.com", "143577218", "Miller", "Korbin", null, "xr57ADMbvg" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Bill_Robel93@yahoo.com", "536404216", "Tillman", "Dale", "oEtu6AcAI0", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Kris32@gmail.com", "987904777", "Abbott", "Alia", "Ena_Emmerich9", "ZWlJhg869k", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Marisol.Padberg@yahoo.com", "490012246", "Torphy", "Darrick", null, "Au0E4fpfwc" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Tyshawn.Kunde2@gmail.com", "675171213", "Krajcik", "Christ", null, "4TfBeg8QaJ", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Maximo_Brekke@yahoo.com", "309885406", "Zieme", "Georgiana", null, "dxh8N4Mwo_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Jayda.Hyatt@hotmail.com", "883297456", "Bergnaum", "Cecilia", null, "4LWLVG2f8U", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Julie.Walker9@hotmail.com", "306205609", "Huels", "Myrtis", "8pAcKxz0gh" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Zella_Waelchi32@yahoo.com", "839315249", "Kuhlman", "Damian", null, "oYYMY6hspk" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Gay.Towne@gmail.com", "603960409", "Larkin", "Retha", "bYjrAhz88L" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Alexzander.Nienow12@gmail.com", "019196198", "Reinger", "Camilla", "Carmela.Hamill97", "t8pwcSQ36Y", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Deangelo_Corwin@yahoo.com", "673524935", "Walsh", "Magnolia", "Delia18", "iVYX1Z5sek" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Roger_Koelpin82@gmail.com", "296062090", "Monahan", "Noelia", null, "EJqoaUVJRF" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Oren.Homenick@gmail.com", "189054016", "Krajcik", "Una", null, "n753uH2M4i", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Jodie60@yahoo.com", "463301192", "Gutkowski", "Kareem", "XcPBkMO3yV", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Dereck.Erdman@gmail.com", "365978703", "Gusikowski", "Angelita", "hQlqY7Lszj", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { "Will0@gmail.com", "238346753", "Lynch", "Loren", "yjkhdxFhAP" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Karolann.Gleason52@yahoo.com", "117675546", "Waelchi", "Amara", "7Pemrt5cjH", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Lorna.Klein97@gmail.com", "615760571", "Krajcik", "Elody", null, "hCvg3tqIw8", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Emerald.Herzog75@hotmail.com", "916373326", "Waters", "Nina", "Xzavier.Nienow34", "Mei1H1R7BE" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Troy36@yahoo.com", "972825860", "Heidenreich", "Randal", "Aidan_Dietrich", "MKQynupzzH" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Gunnar_Hansen@gmail.com", "894580878", "Rogahn", "Melany", "Felicia_Effertz", "VHE3WVDUPT", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Wyman39@gmail.com", "459654943", "Gibson", "Garnet", "Aaliyah_Hagenes", "WuOelojGP2", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Zena_Cummerata@yahoo.com", "819196866", "Hessel", "Rosie", "Melissa.Walker", "PdBsun3wy2", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Estelle_Kirlin@yahoo.com", "881011070", "Mayer", "Joe", null, "J8XhJj49w7" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Matilde77@hotmail.com", "258579165", "Mann", "Finn", "TyHkgf5WXv", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Arnoldo72@yahoo.com", "122994830", "Bauch", "Jolie", "btkhzHNZR6", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hash_vote",
                table: "voters");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Mollie9@yahoo.com", "006119843", "Kovacek", "Carolanne", "Murray.McLaughlin", "ovH15485q1", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Elroy.Carter55@yahoo.com", "151483186", "Emmerich", "Nicola", "iYvkbUOmRp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Federico_Hegmann89@yahoo.com", "772124544", "Gerhold", "Chadrick", "Brian.Bergnaum", "qVYKhBaxXE", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Gerry81@gmail.com", "837488713", "Prosacco", "Oswald", "J8pRoGjDyA" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Braden.Block@gmail.com", "742871645", "Smith", "Jaunita", "lIwiBtfVwp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Vallie.Cronin86@gmail.com", "481704408", "Hirthe", "Godfrey", null, "FcZwcoa_4f", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Deondre30@yahoo.com", "823055478", "Willms", "Merritt", null, "L1fSPOJi72", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Evan75@gmail.com", "347685384", "Carter", "Cedrick", null, "UYxx8MYH0t", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Ollie.McLaughlin27@gmail.com", "329796965", "Wintheiser", "Scottie", "Augustus_Crona6", "Uyu0HwXA5h", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Margarett_McKenzie@hotmail.com", "602404523", "Leffler", "Aric", null, "uY6eZSkMyS", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Damion58@hotmail.com", "144621060", "Hudson", "Glenda", "Mabelle.McGlynn", "cN0LlrPVVL", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Duane_Walsh14@gmail.com", "733334032", "Mosciski", "Ryleigh", "Clotilde.OKeefe25", "WJTlc7yiTR", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Rosalia76@gmail.com", "872249698", "Botsford", "Curt", "Delmer65", "qKuxLnWSIb", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Wiley_Kutch@yahoo.com", "580579397", "Douglas", "Theron", null, "ly95JSXZlL", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Wilhelmine29@hotmail.com", "107558639", "Douglas", "Adriana", "Shemar_Schroeder13", "hKAXi2uOxb" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Jamey.Terry@gmail.com", "823589710", "Carter", "Kira", "Edmund_Bradtke59", "AoliTaPlzS" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Braulio_Morar@yahoo.com", "240581431", "Carter", "Omari", null, "gTHTUPCfi3" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Jennyfer_Green@yahoo.com", "598867842", "Mohr", "Betsy", null, "dMWtpcgmr3", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Rolando21@hotmail.com", "366198168", "Balistreri", "Brenda", "Lois.Streich", "DAkx6T1uz9" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Teagan74@gmail.com", "600487581", "Koelpin", "Dianna", "ElGtTGTpYb", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Evangeline_Graham19@yahoo.com", "455038646", "Bashirian", "Emelia", "Shyanne60", "bRIQsA2cCS", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Tyra_Morissette97@gmail.com", "939381733", "Grimes", "Jairo", "UIW8CBv_ks", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Wilburn_Trantow43@hotmail.com", "533707885", "Murphy", "Nikolas", "mZifCTkAYN" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Melyssa.Lueilwitz70@yahoo.com", "815460431", "Koelpin", "Niko", null, "MFvQYXpsxE" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Randy_Hessel15@gmail.com", "207044394", "VonRueden", "Garrison", "Kelvin_Deckow", "opRsbRH8Vy", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Floy.Reichert77@gmail.com", "495508753", "Bosco", "Cierra", "Aracely44", "1V92KwYMI4" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Burley_Hayes33@hotmail.com", "981330092", "Schmidt", "Dexter", "DWYNt5PiBe", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Ali3@yahoo.com", "289482789", "Hoeger", "Timmothy", null, "fa23I3pwCi", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Colin_Mayer47@gmail.com", "688562362", "Ortiz", "Anabel", "wC1k3DCMvg", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Chaim_Dickens12@gmail.com", "556654814", "Feeney", "Devon", "Nelle33", "uX4FdBDyrt" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Oleta65@gmail.com", "839267029", "Breitenberg", "Peyton", null, "0dDRN8mCHJ", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Elyse_Greenfelder76@gmail.com", "199920460", "Gerlach", "Elyssa", "Laverna81", "QiZyiV62hm", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Jazmin.Ziemann75@yahoo.com", "705723897", "Daniel", "Gonzalo", null, "bTAdoJZc0H", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Beatrice_Predovic52@gmail.com", "506698696", "O'Connell", "Domenico", "USrwnIDNG8", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Avis.Prohaska@gmail.com", "411152833", "Berge", "Amanda", "Aron5", "gXSUWsEURL", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Harley97@gmail.com", "930762299", "Dickinson", "Aric", null, "OQGJ3q5UFR", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Nicholaus_Ortiz@yahoo.com", "675612354", "Blick", "Charley", "Tre26", "QFFtCzjeWh", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Paolo.Thompson49@gmail.com", "435916801", "Morissette", "Harvey", "Brent.Little65", "lMruwWxe5f", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Carmella.Kuhic29@hotmail.com", "793199551", "Roob", "Zakary", "Angel.Williamson44", "4DfKh9Viqe", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Sammie_Cruickshank@gmail.com", "831528561", "McGlynn", "Berniece", "Elbert98", "tqv4jvKsgX", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Kaci_Hettinger61@yahoo.com", "697241841", "Funk", "Shanelle", "Tamara.Bradtke74", "7AWWVFVEX8" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Benton24@gmail.com", "572979024", "O'Conner", "Kenna", "uLUX7nMAtz", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Emie70@yahoo.com", "620225602", "Borer", "Rolando", "Lila_Daniel97", "It3COQsXMt" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Adela_Olson61@gmail.com", "246561445", "Grant", "Quinten", null, "yNcNcbHyFr", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Elna_Tremblay14@gmail.com", "505626424", "Champlin", "Ethel", null, "85zSintqGM" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Frederic.Emmerich54@yahoo.com", "182534825", "Cremin", "Isabel", "Marcellus98", "d0dHSZORAW", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Arianna_Nicolas9@hotmail.com", "561459029", "Rohan", "Lamont", "Lamont17", "XmVJ4nQjiw", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Ramona.Orn@hotmail.com", "784425047", "Metz", "Alex", "Fiona.Kuhic", "lVT4DIModT", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Reagan.Yost@hotmail.com", "245952749", "Macejkovic", "Earl", null, "REYC7YjMae" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Jerrell3@hotmail.com", "328985252", "Bartoletti", "Gillian", null, "jPj1GeLsZJ", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Chase_Wintheiser@gmail.com", "408827298", "Konopelski", "Libby", "b3GkjB7VHn", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Clementina.Reilly24@hotmail.com", "933626358", "Bernier", "Benny", "Blanca_Grady3", "Ekca7YxHpu", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Lavern31@hotmail.com", "222121816", "Reichel", "Fern", "hXORU8Zf_c", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Jolie.Lakin@gmail.com", "648626731", "Ruecker", "Amya", null, "XkMw2m6QOB" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Cathy_Balistreri13@yahoo.com", "094109433", "Borer", "Zella", "Orpha_Kling", "EqhK4aMWRn" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Columbus.Kertzmann9@hotmail.com", "735586663", "Keeling", "Jarrell", null, "zm607S_LlE" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Jordyn.Murazik@gmail.com", "533038764", "Gusikowski", "Alessandro", null, "L2rOIAcEOB", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Devon.Quitzon70@gmail.com", "543698773", "Marquardt", "Jamaal", "Arlene.Mayert62", "SFLYlMbe51", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Mohammad.Schumm26@hotmail.com", "081775615", "Bogisich", "Keven", null, "TOpOGRlt9p", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Joaquin_Treutel@hotmail.com", "012372586", "Turner", "Immanuel", "Vicky52", "J1WMhuDODz" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Emmie73@hotmail.com", "552727175", "Kirlin", "Rahsaan", null, "BeHCVMSDsd", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Waylon.Kovacek@hotmail.com", "660626700", "Donnelly", "Omari", null, "nXfJxTSD_4", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Shanna.Nicolas@yahoo.com", "555918776", "Kunze", "Alexandria", "Princess_Anderson", "qut_VHLhvk", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Alena.Schamberger@yahoo.com", "604000636", "Wolf", "Zachery", "Stacy_VonRueden", "X62eQ4wigI", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "Gilda.Cummings32@gmail.com", "871780503", "McLaughlin", "Haylee", null, "gmOC1FhQe4", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Odie49@yahoo.com", "477846751", "Kerluke", "Tyrel", "Quinton79", "dchDoGt_49", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Sally_Dooley@yahoo.com", "242329691", "Barton", "Percival", "Fiona_Stark", "4Kjj49Ards" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Clyde.Runte38@yahoo.com", "056472520", "Ziemann", "Kristy", "Isom.Cruickshank70", "vnevTgTc7l", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 5, "Adelle_Funk@gmail.com", "222732840", "Moen", "Kenneth", "N0KdDSBEN9" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Madilyn_Abernathy@yahoo.com", "001328381", "Trantow", "Tessie", "Oma_Collins90", "IcAOx1cYmI" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Evert.Kemmer77@hotmail.com", "673674432", "Halvorson", "Kim", "Hertha_Homenick", "jDSxneMTLx" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Vivien_Mills@gmail.com", "222118981", "Schoen", "Denis", "lwAIIbsTrn" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Karli.Brakus@yahoo.com", "915655407", "Runolfsson", "Reid", "Taylor.Windler", "85KcQONG7T", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Silas_Nikolaus@yahoo.com", "940897310", "Kshlerin", "Dariana", "Alessandra80", "_zdEptjSsk" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Adolph_Rogahn@gmail.com", "172134956", "Paucek", "Amy", "UGn6IYPJ6T", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Houston.Corwin46@yahoo.com", "405890131", "Gibson", "Jeremy", null, "UneLaFNSMD", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Lawrence_Vandervort@hotmail.com", "562293563", "Heathcote", "Edythe", "Sammy.Metz", "OXLc2M2Onj" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Theodore_Rosenbaum40@yahoo.com", "366031224", "Lang", "Marcelle", "Keaton_Wolf14", "aJA38X3TMH", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Dennis81@yahoo.com", "104487749", "Moen", "Velma", "Christa.Watsica", "KdP7cJH22N" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Karley35@gmail.com", "138681159", "McLaughlin", "Katarina", "Alexanne.Heaney7", "XJJG7PgQLH", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Betty.Morissette25@hotmail.com", "375024200", "Muller", "Shayna", "n8C0wmstRF" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Maddison_Bergstrom21@gmail.com", "191571526", "Pollich", "Dion", "Hulda_Heller88", "KckfEDNoOi" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 7, "Lue.Ritchie@yahoo.com", "700411314", "Moen", "Burdette", "9gedNwgXmT" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Amely37@yahoo.com", "795878788", "Steuber", "Duane", null, "fL4IRPbKTM", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Jaclyn81@yahoo.com", "153239440", "Corkery", "Shyann", null, "9ERtlEGNmP" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 4, "Enoch.Langworth68@gmail.com", "611686969", "Blick", "Mose", "Tess_Haley", "lAVC2ouBwN" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Loyal58@yahoo.com", "476810056", "Erdman", "Harold", "Abe76", "S_b9dFumhH", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Madalyn27@yahoo.com", "248830194", "Bailey", "Waldo", "2Ve81t_Vhi", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Alden76@yahoo.com", "960814530", "McCullough", "Kane", "HO6htcdaVU", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { "Rasheed.Schuster@gmail.com", "978723986", "Huel", "Heather", "IQV4NkXjdu" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Amira64@gmail.com", "286134027", "Tillman", "Doyle", "D5BIqC6QOI", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Jovan25@yahoo.com", "972713542", "Upton", "Eveline", "Jazlyn.Nader43", "XLJ72MBzxr", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Prince_Toy95@hotmail.com", "786512360", "Satterfield", "Brennan", null, "AOhL7Quzbb" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Rahul_West@yahoo.com", "470757764", "Bernier", "Angelica", null, "BuxB5jgXV7" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Krista_Kulas2@yahoo.com", "486664994", "Quigley", "Joan", "Coleman_Casper", "Yra06HzIlj", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Kaleb.Miller88@yahoo.com", "993140100", "Haag", "Hans", null, "PF8wEJ3EGG", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Alex_Kohler@yahoo.com", "831482405", "Rippin", "Casimer", null, "4DGLjuoPDs", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Ebony.Bartoletti@yahoo.com", "818048707", "Schmitt", "Nettie", "Maddison.Walsh18", "Hs3ymt5ZQc" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Monique43@yahoo.com", "261637489", "Wiza", "Otto", "tWjHcD1G_6", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Jewel_Bins59@hotmail.com", "285155562", "Strosin", "Lance", "aYuIrN_Tay", 3 });
        }
    }
}
