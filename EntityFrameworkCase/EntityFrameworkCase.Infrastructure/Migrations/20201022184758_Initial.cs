using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCase.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirstName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Street",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Street", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surname",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surname", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workplace",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    StreetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workplace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workplace_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workplace_Street_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Street",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNameId = table.Column<int>(nullable: false),
                    SecondNameId = table.Column<int>(nullable: false),
                    SurnameId = table.Column<int>(nullable: false),
                    MotherSurnameId = table.Column<int>(nullable: false),
                    BirthCityId = table.Column<int>(nullable: false),
                    WorkplaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_City_BirthCityId",
                        column: x => x.BirthCityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_FirstName_FirstNameId",
                        column: x => x.FirstNameId,
                        principalTable: "FirstName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Surname_MotherSurnameId",
                        column: x => x.MotherSurnameId,
                        principalTable: "Surname",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_FirstName_SecondNameId",
                        column: x => x.SecondNameId,
                        principalTable: "FirstName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Surname_SurnameId",
                        column: x => x.SurnameId,
                        principalTable: "Surname",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Workplace_WorkplaceId",
                        column: x => x.WorkplaceId,
                        principalTable: "Workplace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_BirthCityId",
                table: "Person",
                column: "BirthCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_FirstNameId",
                table: "Person",
                column: "FirstNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MotherSurnameId",
                table: "Person",
                column: "MotherSurnameId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SecondNameId",
                table: "Person",
                column: "SecondNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SurnameId",
                table: "Person",
                column: "SurnameId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_WorkplaceId",
                table: "Person",
                column: "WorkplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Workplace_CityId",
                table: "Workplace",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Workplace_StreetId",
                table: "Workplace",
                column: "StreetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "FirstName");

            migrationBuilder.DropTable(
                name: "Surname");

            migrationBuilder.DropTable(
                name: "Workplace");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Street");
        }
    }
}
