using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityLoging.EF.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentEntrys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ElectricityPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastMeterNumber = table.Column<int>(type: "int", nullable: false),
                    CurrentMeterNumber = table.Column<int>(type: "int", nullable: false),
                    Difference = table.Column<int>(type: "int", nullable: false),
                    Debt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPayed = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentEntrys", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentEntrys");
        }
    }
}
