using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurePoll_BE.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersWithBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "document_type_id", "email", "identification_number", "last_name", "name", "oauth_google", "password", "role_id" },
                values: new object[,]
                {
                    { 1, 7, "Adolf_Shanahan@yahoo.com", "925139522", "Deckow", "Muhammad", "Sydnie.Kuvalis63", "2TSeBOVHpu", 2 },
                    { 2, 1, "Cullen_Batz70@yahoo.com", "799881569", "Dickens", "Elaina", null, "L8hMWPLa31", 3 },
                    { 3, 5, "Mustafa.Metz@gmail.com", "078203246", "Green", "Myrna", "Patsy.Reilly", "2_qXzUalmG", 2 },
                    { 4, 5, "Gloria_Reinger33@hotmail.com", "261650713", "Oberbrunner", "Genevieve", "Weston.Bode", "1LsZInFH5X", 2 },
                    { 5, 2, "Evie91@yahoo.com", "792382682", "Smith", "Maxwell", "Ismael97", "5FGILiCx6C", 4 },
                    { 6, 7, "Letitia_Padberg76@yahoo.com", "176674915", "Bartoletti", "Desiree", null, "E4mDaYsMsc", 2 },
                    { 7, 2, "Norris_Zieme@hotmail.com", "214191679", "Lueilwitz", "Beth", "Alden40", "ciDW5Ub7o7", 2 },
                    { 8, 7, "Kaitlin.Lemke@hotmail.com", "137320966", "Koepp", "Anastacio", null, "_qZ11mUDtH", 4 },
                    { 9, 6, "Damian_Gerlach89@hotmail.com", "403221265", "Fritsch", "Madeline", "Jude66", "1TwenccyVW", 4 },
                    { 10, 2, "Carissa98@hotmail.com", "663109671", "Krajcik", "Camilla", null, "zOwti66ctH", 3 },
                    { 11, 5, "Cleora67@yahoo.com", "439070940", "Glover", "Geo", "Beaulah50", "bsyXNx08Sh", 3 },
                    { 12, 1, "Destin.Fritsch99@hotmail.com", "548557003", "Reichert", "Alf", null, "8Bl6KHd3ud", 3 },
                    { 13, 3, "Patsy.Walsh@gmail.com", "704069577", "Botsford", "Deshaun", null, "QEmRADtNa2", 4 },
                    { 14, 5, "Dee.OKon26@hotmail.com", "954799228", "Gaylord", "Raymond", null, "IhJjJcNbep", 4 },
                    { 15, 3, "Hermina91@hotmail.com", "705478814", "Wiza", "Frances", "Davonte7", "PuEaTv4sZz", 4 },
                    { 16, 3, "Johathan58@hotmail.com", "605947461", "Gleichner", "Patrick", "Judd_Funk", "BFy3Y3N1We", 2 },
                    { 17, 4, "Beaulah.Ratke@yahoo.com", "535369155", "Yost", "Jedediah", "Jerald_Fay56", "ze8ObRUL7M", 2 },
                    { 18, 5, "Amina_Haley83@yahoo.com", "127713960", "Ebert", "Florine", "Tyrese93", "jOQ5kQOF1q", 4 },
                    { 19, 4, "Zelda.Pfeffer5@hotmail.com", "841613964", "Larson", "Mohamed", null, "n4JdNnHUoK", 3 },
                    { 20, 4, "Constantin19@gmail.com", "692021107", "Hickle", "Magali", "Jamal50", "Py9DVQsS51", 3 },
                    { 21, 5, "Stacey43@hotmail.com", "007190606", "Wolf", "Joe", null, "gpX0rIPxaF", 4 },
                    { 22, 4, "Dejon.Weissnat79@yahoo.com", "253089238", "Oberbrunner", "Jason", "Ericka_Turner67", "sEKlOMxqN4", 3 },
                    { 23, 3, "Marquis2@gmail.com", "228765665", "Larson", "Laurine", null, "1Miiv3DnBT", 2 },
                    { 24, 4, "Lulu.Bosco@hotmail.com", "109673216", "Stanton", "Joshuah", null, "N1gzqJ_DHy", 4 },
                    { 25, 2, "Maximillia.Wisoky51@gmail.com", "734367722", "Langworth", "Samir", null, "4NxgGgSp42", 3 },
                    { 26, 7, "Mandy80@yahoo.com", "392489396", "Mann", "Garrett", null, "3teT2Cbkj8", 4 },
                    { 27, 7, "Robb.Veum25@hotmail.com", "397235061", "Reichel", "Bartholome", null, "XEdN96jy8b", 4 },
                    { 28, 7, "Giovanna_OConner@yahoo.com", "206573449", "Johnson", "Felton", "Lucious_Steuber", "tWf7t3iUNV", 4 },
                    { 29, 5, "Gunnar64@yahoo.com", "740874930", "Ferry", "Lauretta", "Garth_Hansen41", "uQwRcJiYZo", 4 },
                    { 30, 3, "Aidan_McDermott33@hotmail.com", "349797731", "Lockman", "Lenore", null, "F_HHijCS8B", 3 },
                    { 31, 6, "Hoyt_Grimes49@yahoo.com", "934158602", "Franecki", "George", null, "UtjlKUNFs_", 4 },
                    { 32, 6, "Connie.Hartmann@hotmail.com", "239760050", "Leannon", "Sherwood", "Jessica_Ratke", "M7lLnS7hGD", 3 },
                    { 33, 4, "Christina86@hotmail.com", "183105228", "Schamberger", "Lura", null, "HWQPS4r6QE", 2 },
                    { 34, 1, "Lucinda99@hotmail.com", "634736338", "Heaney", "Clair", "Kelsi.Pouros59", "IinoyNylJg", 3 },
                    { 35, 6, "Dena_Hoeger37@hotmail.com", "531471693", "Predovic", "Isom", "Patsy.Parisian34", "YGo9q9qe5C", 4 },
                    { 36, 3, "Clement_Grimes27@gmail.com", "182176486", "Batz", "Isaac", null, "jDXDF0Y72G", 3 },
                    { 37, 1, "Jadon.Streich@hotmail.com", "193863843", "Stehr", "Keven", "Celine_Cormier49", "qPh1donEZf", 4 },
                    { 38, 7, "Electa_Kulas@yahoo.com", "730499113", "Homenick", "Myriam", null, "qiKcOrNUyL", 3 },
                    { 39, 4, "Kurt21@yahoo.com", "354013526", "Trantow", "Rickey", null, "fkxB24_5g7", 4 },
                    { 40, 6, "Edgardo_Borer50@hotmail.com", "104196641", "Auer", "Sierra", "Alfred.Leuschke", "JBiJzZzRI7", 2 },
                    { 41, 4, "Quentin_Bartoletti@gmail.com", "889075280", "Kilback", "Marquis", null, "EtZpl2xI7g", 3 },
                    { 42, 5, "Kenya.Jakubowski25@gmail.com", "591877560", "Rowe", "Kris", null, "tQoYIyJ08_", 3 },
                    { 43, 5, "Oscar_Kuvalis48@gmail.com", "908110841", "Windler", "Adrien", "Johnpaul.Muller47", "p2R9yNmgp0", 3 },
                    { 44, 2, "Juvenal.Lehner@gmail.com", "686969799", "Kuvalis", "Crawford", null, "NXwsO0rTBE", 2 },
                    { 45, 6, "Einar.Purdy@hotmail.com", "877623946", "Bode", "Berniece", null, "Zt3g5a9Zw3", 2 },
                    { 46, 4, "Oda43@hotmail.com", "167160546", "Hahn", "Colten", null, "fQOZzrK2e0", 3 },
                    { 47, 1, "Zaria.Von28@hotmail.com", "619718410", "Nitzsche", "Mireya", "Liliane72", "fR8Yis29ZH", 3 },
                    { 48, 7, "Dominique81@gmail.com", "595697141", "Grimes", "Nelson", "Clay64", "tZmlFknui_", 3 },
                    { 49, 5, "Gino_Homenick@yahoo.com", "845703403", "Pfannerstill", "Electa", "Fred94", "XicxfoUMn_", 3 },
                    { 50, 1, "Misael97@gmail.com", "775288086", "O'Kon", "Dovie", null, "BK246q5agF", 2 },
                    { 51, 6, "Omari41@hotmail.com", "586563104", "Jerde", "Carolyn", null, "nx0GXR53Zo", 4 },
                    { 52, 7, "Mariela_Johns85@yahoo.com", "487023908", "Gorczany", "Dovie", null, "OQzprCcNYv", 3 },
                    { 53, 1, "Deion.Grant@hotmail.com", "245016421", "Boyer", "Ilene", "Miracle82", "y7mtlWrImd", 3 },
                    { 54, 4, "Nicklaus.Pacocha@hotmail.com", "870161033", "Tillman", "Donnie", "Kailee.Muller47", "loPnCOHDc1", 2 },
                    { 55, 1, "Krystel18@gmail.com", "964429439", "O'Connell", "Ciara", null, "hUggLxr5iH", 3 },
                    { 56, 4, "Felipe_Hodkiewicz62@hotmail.com", "736345989", "Dicki", "Quentin", null, "I2p2qnT9g_", 4 },
                    { 57, 3, "Tod_Cassin@hotmail.com", "879848182", "Keebler", "Keshawn", "Reinhold.Romaguera", "P_oTDE0zWj", 3 },
                    { 58, 1, "Alexandra.Bauch@gmail.com", "080576463", "Hermiston", "Brenden", "Donny_Weber", "r2RKjiUMaS", 4 },
                    { 59, 3, "Rupert_Bartoletti28@yahoo.com", "083023451", "Effertz", "Jaren", "Duncan.Zboncak", "bneEy5P1rM", 2 },
                    { 60, 3, "Malachi_Dickinson87@gmail.com", "762550834", "Hickle", "Kelley", "Winfield_Zieme", "hHlMu13Hhy", 2 },
                    { 61, 1, "Alanna.Greenfelder@yahoo.com", "219652433", "Langosh", "Candida", "Kendra.Daugherty", "Umb58q5sbK", 3 },
                    { 62, 5, "Elena80@gmail.com", "719008521", "Stamm", "Eladio", "Mack_Kuphal", "YYD3qEv8eu", 4 },
                    { 63, 3, "Jerald57@hotmail.com", "638783975", "Heidenreich", "Austyn", null, "MQmRlKIPga", 2 },
                    { 64, 7, "Henderson42@gmail.com", "672883798", "Witting", "Margarita", "Maximilian.Lakin", "q5L8u4r_KX", 4 },
                    { 65, 7, "Gordon.Von@yahoo.com", "800717637", "Bauch", "Carlotta", "Carlie.Sanford76", "0Jp2zsn_zr", 3 },
                    { 66, 7, "Sarai_Beier@yahoo.com", "797362976", "Gaylord", "Rhoda", "Mellie.Kuphal90", "5CO_P5SSR1", 2 },
                    { 67, 7, "Arne.Block13@gmail.com", "792495285", "Glover", "Thelma", "Spencer11", "YqWfmm0ztT", 2 },
                    { 68, 5, "Connor.Koelpin66@hotmail.com", "288962783", "Robel", "Arnaldo", null, "oQr9uIktlh", 2 },
                    { 69, 4, "Trystan75@hotmail.com", "351828141", "Kuphal", "Stephanie", null, "Hf6rraiI2t", 4 },
                    { 70, 5, "Clemmie_Padberg82@yahoo.com", "892326323", "Mitchell", "Macy", null, "rRgkIoBw_Y", 4 },
                    { 71, 6, "Lyda94@yahoo.com", "842615262", "Kozey", "Reggie", null, "aXElFFG3Pe", 2 },
                    { 72, 6, "Reid_Monahan97@gmail.com", "982267695", "Wiza", "Myrtis", "Zita29", "r2x0xRlUkN", 3 },
                    { 73, 2, "Nico65@gmail.com", "200164459", "Kautzer", "Scarlett", null, "RjhkU3yVYc", 3 },
                    { 74, 6, "Mollie_Littel@hotmail.com", "783088538", "Rohan", "Louvenia", null, "bYfmZBSfz3", 4 },
                    { 75, 7, "Jeanette41@hotmail.com", "165571320", "Wintheiser", "Justus", null, "mzaeUCV0zi", 4 },
                    { 76, 5, "Madison72@hotmail.com", "349852702", "Dietrich", "Heloise", "Lia_Collins46", "o8FQ_jsn4l", 4 },
                    { 77, 4, "Tavares_Pouros45@hotmail.com", "402482906", "Homenick", "Gladyce", null, "F4FsIOUgkQ", 4 },
                    { 78, 4, "Eunice_Nolan@hotmail.com", "073278130", "Towne", "Mireya", null, "f1cgdDm1ev", 3 },
                    { 79, 2, "Kennedi65@yahoo.com", "072800553", "Hyatt", "Ozella", "Malcolm71", "JjaYjLroEE", 3 },
                    { 80, 5, "Addison.Douglas25@yahoo.com", "929446194", "Robel", "Sigmund", null, "q8N5GEs0PN", 2 },
                    { 81, 4, "Orlando_Glover@gmail.com", "999720719", "Davis", "Hortense", null, "tW4v71G0PZ", 3 },
                    { 82, 7, "Lloyd_McGlynn80@hotmail.com", "481705012", "Ortiz", "Nora", "Francesco82", "lblhuqlKSO", 3 },
                    { 83, 6, "Samson24@yahoo.com", "662945369", "Walker", "Kenna", null, "gjEK4AdC9B", 2 },
                    { 84, 7, "Ramon79@hotmail.com", "194360691", "Tromp", "Isabelle", null, "J3tES3aQpV", 3 },
                    { 85, 6, "Eldora_Quigley@gmail.com", "199821692", "Jones", "Rhiannon", null, "sClxboF2vT", 3 },
                    { 86, 6, "Leda_Moen99@hotmail.com", "554233092", "O'Kon", "Brannon", null, "S1rv2Vhoeu", 4 },
                    { 87, 2, "Dorcas.Rodriguez@hotmail.com", "301884698", "Jacobs", "Lawson", "Sheridan_Armstrong", "g8fhECHbC_", 4 },
                    { 88, 6, "Brendon_King@yahoo.com", "092009973", "Russel", "Kevon", "Gussie.Conn17", "dHPbaCKQlM", 2 },
                    { 89, 5, "Keely_Klein19@yahoo.com", "690777871", "Dicki", "Abraham", null, "E_xc6s83k4", 3 },
                    { 90, 6, "Jeremy60@yahoo.com", "720536971", "Wolff", "Syble", null, "4jTCtij_zK", 2 },
                    { 91, 5, "Destin.Haag88@hotmail.com", "882244743", "Mante", "Amir", "Freeda_Bayer", "3LEFwTFU8W", 2 },
                    { 92, 6, "Matilde.Lueilwitz27@yahoo.com", "162714698", "Huels", "Jonas", null, "AahYWLNxFC", 3 },
                    { 93, 3, "Nicolette61@yahoo.com", "978326755", "Schamberger", "Savanna", "Esteban97", "UON8b1LIN0", 2 },
                    { 94, 4, "Dangelo.Christiansen@gmail.com", "044379370", "Baumbach", "Marcelle", "Allene.Schimmel", "LENPSJT4k4", 3 },
                    { 95, 1, "Elwyn17@hotmail.com", "722864633", "Kreiger", "Janis", null, "j40XgZ7RcR", 2 },
                    { 96, 3, "Oceane.Paucek@yahoo.com", "718602350", "Vandervort", "Opal", "Teresa.Cruickshank1", "pNfJtA0goo", 4 },
                    { 97, 7, "Eldon12@gmail.com", "653034579", "Brekke", "Jane", "Marian_Jacobs46", "gUtSHJMkH3", 4 },
                    { 98, 5, "Mateo10@hotmail.com", "702214277", "Price", "Lolita", "Jerome.Cummings64", "EiDJVJROO0", 2 },
                    { 99, 6, "Oceane_Blanda@hotmail.com", "037499605", "Wiegand", "Fabian", "Yvonne_Koelpin66", "s9mWyNLI7r", 2 },
                    { 100, 3, "Yvette71@yahoo.com", "092956977", "Pacocha", "Isaias", "Katlynn18", "iqKyrpSHEm", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
