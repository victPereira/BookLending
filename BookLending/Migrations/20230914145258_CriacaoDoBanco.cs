using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLending.Migrations
{
    public partial class CriacaoDoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lending",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookLend = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEndAtt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lending", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lending");
        }
    }
}
