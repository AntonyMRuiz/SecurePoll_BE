using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurePoll_BE.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnPublicKeyIntoUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "public_key",
                table: "users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Mollie9@yahoo.com", "006119843", "Kovacek", "Carolanne", "Murray.McLaughlin", "ovH15485q1", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Elroy.Carter55@yahoo.com", "151483186", "Emmerich", "Nicola", null, "iYvkbUOmRp", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 7, "Federico_Hegmann89@yahoo.com", "772124544", "Gerhold", "Chadrick", "Brian.Bergnaum", "qVYKhBaxXE", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key" },
                values: new object[] { 7, "Gerry81@gmail.com", "837488713", "Prosacco", "Oswald", "J8pRoGjDyA", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 2, "Braden.Block@gmail.com", "742871645", "Smith", "Jaunita", null, "lIwiBtfVwp", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Vallie.Cronin86@gmail.com", "481704408", "Hirthe", "Godfrey", null, "FcZwcoa_4f", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key" },
                values: new object[] { 2, "Deondre30@yahoo.com", "823055478", "Willms", "Merritt", "L1fSPOJi72", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 2, "Evan75@gmail.com", "347685384", "Carter", "Cedrick", "UYxx8MYH0t", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 6, "Ollie.McLaughlin27@gmail.com", "329796965", "Wintheiser", "Scottie", "Augustus_Crona6", "Uyu0HwXA5h", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 1, "Margarett_McKenzie@hotmail.com", "602404523", "Leffler", "Aric", null, "uY6eZSkMyS", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 2, "Damion58@hotmail.com", "144621060", "Hudson", "Glenda", "Mabelle.McGlynn", "cN0LlrPVVL", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 1, "Duane_Walsh14@gmail.com", "733334032", "Mosciski", "Ryleigh", "Clotilde.OKeefe25", "WJTlc7yiTR", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 3, "Rosalia76@gmail.com", "872249698", "Botsford", "Curt", "Delmer65", "qKuxLnWSIb", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 7, "Wiley_Kutch@yahoo.com", "580579397", "Douglas", "Theron", "ly95JSXZlL", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 7, "Wilhelmine29@hotmail.com", "107558639", "Douglas", "Adriana", "Shemar_Schroeder13", "hKAXi2uOxb", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { "Jamey.Terry@gmail.com", "823589710", "Carter", "Kira", "Edmund_Bradtke59", "AoliTaPlzS", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 7, "Braulio_Morar@yahoo.com", "240581431", "Carter", "Omari", null, "gTHTUPCfi3", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 7, "Jennyfer_Green@yahoo.com", "598867842", "Mohr", "Betsy", "dMWtpcgmr3", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 7, "Rolando21@hotmail.com", "366198168", "Balistreri", "Brenda", "Lois.Streich", "DAkx6T1uz9", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key" },
                values: new object[] { 6, "Teagan74@gmail.com", "600487581", "Koelpin", "Dianna", "ElGtTGTpYb", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 3, "Evangeline_Graham19@yahoo.com", "455038646", "Bashirian", "Emelia", "Shyanne60", "bRIQsA2cCS", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key" },
                values: new object[] { 2, "Tyra_Morissette97@gmail.com", "939381733", "Grimes", "Jairo", "UIW8CBv_ks", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Wilburn_Trantow43@hotmail.com", "533707885", "Murphy", "Nikolas", null, "mZifCTkAYN", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 1, "Melyssa.Lueilwitz70@yahoo.com", "815460431", "Koelpin", "Niko", "MFvQYXpsxE", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Randy_Hessel15@gmail.com", "207044394", "VonRueden", "Garrison", "Kelvin_Deckow", "opRsbRH8Vy", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 6, "Floy.Reichert77@gmail.com", "495508753", "Bosco", "Cierra", "Aracely44", "1V92KwYMI4", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 4, "Burley_Hayes33@hotmail.com", "981330092", "Schmidt", "Dexter", "DWYNt5PiBe", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 7, "Ali3@yahoo.com", "289482789", "Hoeger", "Timmothy", "fa23I3pwCi", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 6, "Colin_Mayer47@gmail.com", "688562362", "Ortiz", "Anabel", null, "wC1k3DCMvg", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 5, "Chaim_Dickens12@gmail.com", "556654814", "Feeney", "Devon", "Nelle33", "uX4FdBDyrt", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 1, "Oleta65@gmail.com", "839267029", "Breitenberg", "Peyton", "0dDRN8mCHJ", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 3, "Elyse_Greenfelder76@gmail.com", "199920460", "Gerlach", "Elyssa", "Laverna81", "QiZyiV62hm", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Jazmin.Ziemann75@yahoo.com", "705723897", "Daniel", "Gonzalo", null, "bTAdoJZc0H", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key" },
                values: new object[] { 4, "Beatrice_Predovic52@gmail.com", "506698696", "O'Connell", "Domenico", "USrwnIDNG8", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 4, "Avis.Prohaska@gmail.com", "411152833", "Berge", "Amanda", "Aron5", "gXSUWsEURL", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 2, "Harley97@gmail.com", "930762299", "Dickinson", "Aric", null, "OQGJ3q5UFR", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Nicholaus_Ortiz@yahoo.com", "675612354", "Blick", "Charley", "Tre26", "QFFtCzjeWh", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 2, "Paolo.Thompson49@gmail.com", "435916801", "Morissette", "Harvey", "Brent.Little65", "lMruwWxe5f", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 7, "Carmella.Kuhic29@hotmail.com", "793199551", "Roob", "Zakary", "Angel.Williamson44", "4DfKh9Viqe", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 2, "Sammie_Cruickshank@gmail.com", "831528561", "McGlynn", "Berniece", "Elbert98", "tqv4jvKsgX", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Kaci_Hettinger61@yahoo.com", "697241841", "Funk", "Shanelle", "Tamara.Bradtke74", "7AWWVFVEX8", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 6, "Benton24@gmail.com", "572979024", "O'Conner", "Kenna", "uLUX7nMAtz", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { "Emie70@yahoo.com", "620225602", "Borer", "Rolando", "Lila_Daniel97", "It3COQsXMt", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { "Adela_Olson61@gmail.com", "246561445", "Grant", "Quinten", null, "yNcNcbHyFr", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 7, "Elna_Tremblay14@gmail.com", "505626424", "Champlin", "Ethel", null, "85zSintqGM", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 1, "Frederic.Emmerich54@yahoo.com", "182534825", "Cremin", "Isabel", "Marcellus98", "d0dHSZORAW", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 1, "Arianna_Nicolas9@hotmail.com", "561459029", "Rohan", "Lamont", "Lamont17", "XmVJ4nQjiw", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 1, "Ramona.Orn@hotmail.com", "784425047", "Metz", "Alex", "Fiona.Kuhic", "lVT4DIModT", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { "Reagan.Yost@hotmail.com", "245952749", "Macejkovic", "Earl", "REYC7YjMae", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Jerrell3@hotmail.com", "328985252", "Bartoletti", "Gillian", null, "jPj1GeLsZJ", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 1, "Chase_Wintheiser@gmail.com", "408827298", "Konopelski", "Libby", null, "b3GkjB7VHn", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 6, "Clementina.Reilly24@hotmail.com", "933626358", "Bernier", "Benny", "Blanca_Grady3", "Ekca7YxHpu", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 1, "Lavern31@hotmail.com", "222121816", "Reichel", "Fern", null, "hXORU8Zf_c", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 5, "Jolie.Lakin@gmail.com", "648626731", "Ruecker", "Amya", null, "XkMw2m6QOB", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Cathy_Balistreri13@yahoo.com", "094109433", "Borer", "Zella", "Orpha_Kling", "EqhK4aMWRn", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Columbus.Kertzmann9@hotmail.com", "735586663", "Keeling", "Jarrell", null, "zm607S_LlE", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key" },
                values: new object[] { 1, "Jordyn.Murazik@gmail.com", "533038764", "Gusikowski", "Alessandro", "L2rOIAcEOB", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Devon.Quitzon70@gmail.com", "543698773", "Marquardt", "Jamaal", "Arlene.Mayert62", "SFLYlMbe51", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 1, "Mohammad.Schumm26@hotmail.com", "081775615", "Bogisich", "Keven", null, "TOpOGRlt9p", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Joaquin_Treutel@hotmail.com", "012372586", "Turner", "Immanuel", "Vicky52", "J1WMhuDODz", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 3, "Emmie73@hotmail.com", "552727175", "Kirlin", "Rahsaan", "BeHCVMSDsd", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 2, "Waylon.Kovacek@hotmail.com", "660626700", "Donnelly", "Omari", "nXfJxTSD_4", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Shanna.Nicolas@yahoo.com", "555918776", "Kunze", "Alexandria", "Princess_Anderson", "qut_VHLhvk", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 5, "Alena.Schamberger@yahoo.com", "604000636", "Wolf", "Zachery", "Stacy_VonRueden", "X62eQ4wigI", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 5, "Gilda.Cummings32@gmail.com", "871780503", "McLaughlin", "Haylee", null, "gmOC1FhQe4", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 4, "Odie49@yahoo.com", "477846751", "Kerluke", "Tyrel", "Quinton79", "dchDoGt_49", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 7, "Sally_Dooley@yahoo.com", "242329691", "Barton", "Percival", "Fiona_Stark", "4Kjj49Ards", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { "Clyde.Runte38@yahoo.com", "056472520", "Ziemann", "Kristy", "Isom.Cruickshank70", "vnevTgTc7l", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 5, "Adelle_Funk@gmail.com", "222732840", "Moen", "Kenneth", null, "N0KdDSBEN9", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Madilyn_Abernathy@yahoo.com", "001328381", "Trantow", "Tessie", "Oma_Collins90", "IcAOx1cYmI", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 3, "Evert.Kemmer77@hotmail.com", "673674432", "Halvorson", "Kim", "Hertha_Homenick", "jDSxneMTLx", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 6, "Vivien_Mills@gmail.com", "222118981", "Schoen", "Denis", "lwAIIbsTrn", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { "Karli.Brakus@yahoo.com", "915655407", "Runolfsson", "Reid", "Taylor.Windler", "85KcQONG7T", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 2, "Silas_Nikolaus@yahoo.com", "940897310", "Kshlerin", "Dariana", "Alessandra80", "_zdEptjSsk", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 7, "Adolph_Rogahn@gmail.com", "172134956", "Paucek", "Amy", null, "UGn6IYPJ6T", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 3, "Houston.Corwin46@yahoo.com", "405890131", "Gibson", "Jeremy", "UneLaFNSMD", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 4, "Lawrence_Vandervort@hotmail.com", "562293563", "Heathcote", "Edythe", "Sammy.Metz", "OXLc2M2Onj", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 1, "Theodore_Rosenbaum40@yahoo.com", "366031224", "Lang", "Marcelle", "Keaton_Wolf14", "aJA38X3TMH", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 2, "Dennis81@yahoo.com", "104487749", "Moen", "Velma", "Christa.Watsica", "KdP7cJH22N", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 1, "Karley35@gmail.com", "138681159", "McLaughlin", "Katarina", "Alexanne.Heaney7", "XJJG7PgQLH", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { "Betty.Morissette25@hotmail.com", "375024200", "Muller", "Shayna", "n8C0wmstRF", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Maddison_Bergstrom21@gmail.com", "191571526", "Pollich", "Dion", "Hulda_Heller88", "KckfEDNoOi", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key" },
                values: new object[] { 7, "Lue.Ritchie@yahoo.com", "700411314", "Moen", "Burdette", "9gedNwgXmT", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Amely37@yahoo.com", "795878788", "Steuber", "Duane", null, "fL4IRPbKTM", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 3, "Jaclyn81@yahoo.com", "153239440", "Corkery", "Shyann", "9ERtlEGNmP", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 4, "Enoch.Langworth68@gmail.com", "611686969", "Blick", "Mose", "Tess_Haley", "lAVC2ouBwN", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 3, "Loyal58@yahoo.com", "476810056", "Erdman", "Harold", "Abe76", "S_b9dFumhH", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 1, "Madalyn27@yahoo.com", "248830194", "Bailey", "Waldo", "2Ve81t_Vhi", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 4, "Alden76@yahoo.com", "960814530", "McCullough", "Kane", null, "HO6htcdaVU", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 1, "Rasheed.Schuster@gmail.com", "978723986", "Huel", "Heather", null, "IQV4NkXjdu", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 1, "Amira64@gmail.com", "286134027", "Tillman", "Doyle", null, "D5BIqC6QOI", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 2, "Jovan25@yahoo.com", "972713542", "Upton", "Eveline", "Jazlyn.Nader43", "XLJ72MBzxr", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 6, "Prince_Toy95@hotmail.com", "786512360", "Satterfield", "Brennan", "AOhL7Quzbb", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 3, "Rahul_West@yahoo.com", "470757764", "Bernier", "Angelica", null, "BuxB5jgXV7", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 6, "Krista_Kulas2@yahoo.com", "486664994", "Quigley", "Joan", "Coleman_Casper", "Yra06HzIlj", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 2, "Kaleb.Miller88@yahoo.com", "993140100", "Haag", "Hans", null, "PF8wEJ3EGG", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 7, "Alex_Kohler@yahoo.com", "831482405", "Rippin", "Casimer", null, "4DGLjuoPDs", null, 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key", "role_id" },
                values: new object[] { 1, "Ebony.Bartoletti@yahoo.com", "818048707", "Schmitt", "Nettie", "Maddison.Walsh18", "Hs3ymt5ZQc", null, 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "public_key", "role_id" },
                values: new object[] { 2, "Monique43@yahoo.com", "261637489", "Wiza", "Otto", "tWjHcD1G_6", null, 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "public_key" },
                values: new object[] { 4, "Jewel_Bins59@hotmail.com", "285155562", "Strosin", "Lance", null, "aYuIrN_Tay", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "public_key",
                table: "users");

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Malika_Doyle28@hotmail.com", "922344586", "Johns", "Dena", "Ben57", "dc_oTqkAXt", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Misty.Toy@gmail.com", "698964737", "Schmeler", "Rhianna", "WRk9AFweAB" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Arlo79@yahoo.com", "460474398", "Harris", "Hassie", "Dudley.Veum86", "eKOijp9TgH", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 1, "Emelia_Cole@gmail.com", "449651857", "Conn", "Mckenzie", "75tKY9EDmR" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Rahul_Tremblay5@gmail.com", "281183628", "Collins", "Haven", "8xAQcYwmbI", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Tiara_Roberts35@hotmail.com", "055415376", "Sporer", "Abdul", null, "i11chJaTOF" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Leonard55@hotmail.com", "005493632", "Gerhold", "London", "Leonardo58", "IiiiMlfFzy" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Evan_Kutch@gmail.com", "122500061", "Schuppe", "Lorenz", "Dariana_Strosin", "DwlrBKCEr_" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Moises61@yahoo.com", "375009676", "Stark", "Ulises", "Luis_Tillman6", "5KnvCeZKQn", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Dustin.Denesik87@yahoo.com", "780261886", "Hudson", "Solon", "London93", "CCaqj7IIYc" });

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
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Fred_Flatley96@yahoo.com", "431129633", "Stroman", "Makenna", null, "PNnGup1JWd" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Ryley.Mosciski3@yahoo.com", "474326099", "McClure", "Crawford", "Zaria.Schroeder", "wGR72EJAv3" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Lonny_Yost10@yahoo.com", "499580598", "Cruickshank", "Lionel", "B608EBWn1C" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 3, "Lia65@gmail.com", "416404615", "Ziemann", "Roy", "8BIUUTbzPl" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 5, "Tyrique62@yahoo.com", "479155114", "McKenzie", "Johnny", "R3stwoTRsG", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Earnest14@hotmail.com", "979889693", "Rice", "Anastasia", "Mavis.Murray74", "WE7x8ly86z", 4 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Roberto_Beatty@gmail.com", "996452688", "Bins", "Ernesto", "HDPzCzgR13", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 1, "Marcelle_Schuster@yahoo.com", "673476401", "Sanford", "Syble", "Lacey_Doyle", "GsDIfP42tr" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Nathaniel49@yahoo.com", "765719183", "Kihn", "Billy", null, "CB2jP5rixp" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Cassie.Waters44@yahoo.com", "671753462", "Reilly", "Maria", "Anika_Rempel", "EAYFY5F5S6", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 2, "Graciela.Kulas2@hotmail.com", "599775684", "Murazik", "Franco", "d6Vv7m73n5" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 5, "May63@hotmail.com", "821793131", "Hoppe", "Tyrique", "Donna.Jacobi", "FqxeFHu3P_", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Raheem69@gmail.com", "611758152", "Legros", "Danyka", null, "nggJWrTpfB", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Orville_Kris7@hotmail.com", "218621725", "Tremblay", "Wiley", null, "r7Cr6fBJ9y", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Alanna65@gmail.com", "297952148", "Carroll", "David", null, "87IA_zDPcJ" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 3, "Mohammad24@gmail.com", "897417596", "Hammes", "Stefanie", "WLETRyM4PU", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { "Noel10@yahoo.com", "391419118", "Dare", "Ephraim", null, "0ACRoRsYnA" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Milan_Emard@hotmail.com", "351029537", "Krajcik", "Etha", "Marshall.Christiansen90", "vGdmnwMktI", 2 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Mireille_DAmore7@gmail.com", "630463437", "Gottlieb", "Jayson", null, "YpepI5rS8f" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Annetta12@hotmail.com", "511164465", "Sauer", "Antonina", null, "gp88GtRVEX" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Bertram9@yahoo.com", "470474625", "Schmidt", "Destini", "Valentin_Parisian", "VcOQBTvMD7" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Alverta80@yahoo.com", "734904766", "Wisoky", "Edward", "Dave.Cassin61", "QcfA9WyMdA", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 3, "Annie_Sawayn36@hotmail.com", "207304332", "Beier", "Dejah", "Floy_Tromp", "ukj_sP7yIB" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Ariane_Spinka@gmail.com", "682121109", "Smith", "Lura", "Chelsie.Ward31", "kcoSoPBlRQ" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 5, "Bella_Upton@yahoo.com", "019991836", "Marquardt", "Johnathan", "Osbaldo.Rolfson", "2qpzKGhMnz" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Gloria_Raynor@hotmail.com", "368651725", "Hagenes", "Jeff", null, "zkkWOOk3Ts", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Mitchell.Goldner@hotmail.com", "807106732", "Goyette", "Marjory", "Jeffry_Huels", "pSfg8omLFo", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 6, "Fern_DAmore79@yahoo.com", "012324003", "Anderson", "Alford", "_7oV6a5Fdo" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Damaris_Hansen64@yahoo.com", "649572332", "Mosciski", "Hassie", "Webster59", "YjNbQUc1SJ", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Justen68@gmail.com", "327871687", "Lehner", "Letitia", "Maximilian_Auer12", "d1_0vxHq6W", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Mauricio.Kiehn10@yahoo.com", "458071754", "Emard", "Ludwig", null, "i51ATt4_jo", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 1, "Oliver_Turner@gmail.com", "036163613", "Halvorson", "Kristofer", "sR6QLvuSVT", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Frankie56@hotmail.com", "660318405", "Schoen", "Janessa", null, "twWMg3gIml", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 2, "Chloe46@hotmail.com", "816245172", "Nitzsche", "Tessie", "Shayna_Crooks39", "9sbnROTFxO" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 1, "Cayla.Walker@gmail.com", "127020157", "Labadie", "Leopoldo", "Jane_McDermott13", "yPmOz8MsES", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Mara58@yahoo.com", "529068708", "Collins", "Delphia", "Cicero_Wilderman87", "eMyIED2mFd", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Anahi98@gmail.com", "878704263", "Shields", "Ruby", "Oswaldo.Nikolaus", "bWEe3NxueD", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Elsa_Blick@yahoo.com", "405318185", "Reilly", "Owen", "Reinhold_Conn", "S0wxgqc3xx", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Diana.Kuhic90@hotmail.com", "348249903", "Effertz", "Reina", null, "yzXBUU8qPR" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 7, "Audra89@hotmail.com", "173519699", "Parisian", "Nayeli", "i2i4frDvpV", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { "Hunter_Hudson@yahoo.com", "192480646", "Marvin", "Eleonore", null, "2i7mdwh9YA", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Bryon_Price40@yahoo.com", "105892468", "Veum", "Alfred", null, "pgGmhVCvse", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 2, "Pete64@yahoo.com", "775917730", "Blick", "Garrett", "fqhQQc2jB_", 2 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 6, "Mallie.Lemke73@gmail.com", "725952948", "Johns", "Oral", null, "D2SyOo_e2R" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Nolan46@gmail.com", "030342516", "Jerde", "Dee", "Lambert_Legros", "1bGf2r1hYY", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { "Kendra_Metz@gmail.com", "256640022", "Renner", "Jessica", "JjBlsMZSmu", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 3, "Garrick.Schmitt@gmail.com", "920192956", "Gibson", "Karelle", null, "ydAIoA_WtK", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password" },
                values: new object[] { 4, "Izabella.Hintz7@hotmail.com", "517547330", "Bins", "Erich", "2rdi3rPjYa" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 4, "Gretchen.Cummerata@hotmail.com", "206370644", "Abbott", "Nicolas", "WHzAFHmpW2", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Winifred_Mills@hotmail.com", "158075436", "Bahringer", "Lawrence", "Kelvin_Cummings", "X9JaMF346S" });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 6, "Leo_Legros@gmail.com", "634811846", "Reichel", "Serena", "Frankie14", "SGzQPMu_w0", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 2, "Drake_Parker84@hotmail.com", "770849342", "Stehr", "Mark", "Abbigail22", "07gOzI51Hl", 3 });

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
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 4, "Rosalia43@gmail.com", "639610618", "Legros", "Jade", "Abigale_Blick16", "l4sQPNTIdN", 4 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[] { 7, "Rhiannon_Anderson@gmail.com", "016562463", "Daugherty", "Jessyca", "Ladarius.OHara88", "5RSD531Siy", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "password", "role_id" },
                values: new object[] { 6, "Noble_Ullrich@gmail.com", "815394296", "Greenholt", "Buster", "xIE6LIP5H3", 3 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password" },
                values: new object[] { 7, "Berry5@hotmail.com", "786899412", "Walter", "Leonora", "Elfrieda17", "rOwxKQh0qn" });
        }
    }
}
