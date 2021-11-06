using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab04.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinceName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    Population = table.Column<int>(type: "INTEGER", nullable: false),
                    ProvinceCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Province",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "AB", "Alberta" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "BC", "British Columbia" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "MB", "Manitoba" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "NB", "New Brunswick" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "NL", "Newfoundland" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "NS", "Nova Scotia" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "ON", "Ontario" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "PE", "Prince Edward Island" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "QC", "Quebec" });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "SK", "Saskatchewan" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 1, "Edmonton", 165121, "AB" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 2, "Calgary", 135234, "AB" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 3, "Victoria", 18951, "BC" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 4, "Vancouver", 244895, "BC" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 5, "Winnipeg", 83155, "MB" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 6, "Fredericton", 18623, "NB" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 7, "Moncton", 1816513, "NB" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 8, "St.John's", 48913, "NL" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 9, "Halifax", 498564, "NS" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 10, "Toronto", 849156, "ON" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 11, "Charlottetown", 198137, "PE" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 12, "Quebec City", 908465, "QC" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 13, "Regina", 4442879, "SK" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityName", "Population", "ProvinceCode" },
                values: new object[] { 14, "Saskatoon", 716129, "SK" });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode",
                table: "City",
                column: "ProvinceCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
