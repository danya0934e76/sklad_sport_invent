using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sklad_sport_invent.Context.Migrations
{
    public partial class Danepa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpDatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpDatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nakladnaya",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpDatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpDatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nakladnaya", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeraIzmer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valueUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpDatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpDatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressSkl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactFace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpDatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpDatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNumP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoverenoeL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpDatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpDatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VedomProductItrem",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Summ = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NakladnayaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VedomProductItrem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VedomProductItrem_Nakladnaya_NakladnayaId",
                        column: x => x.NakladnayaId,
                        principalTable: "Nakladnaya",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VedomProductItrem_NakladnayaId",
                table: "VedomProductItrem",
                column: "NakladnayaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "VedomProductItrem");

            migrationBuilder.DropTable(
                name: "Nakladnaya");
        }
    }
}
