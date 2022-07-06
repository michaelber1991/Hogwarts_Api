using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hogwarts.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdmissionRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Identification = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<short>(type: "smallint", maxLength: 10, nullable: false),
                    HouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdmissionRequest_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "House",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f444e63-249c-4f72-a031-d5df767fa456"), "Ravenclaw" },
                    { new Guid("11e6f800-a51d-4981-bd1b-a7ce662323b7"), "Gryffindor" },
                    { new Guid("a01844d7-e79a-475d-b87d-91dd55776e0f"), "Slytherin" },
                    { new Guid("d4345b32-b146-41b4-ab0c-53e82c47d07e"), "Hufflepuff" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionRequest_HouseId",
                table: "AdmissionRequest",
                column: "HouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionRequest");

            migrationBuilder.DropTable(
                name: "House");
        }
    }
}
