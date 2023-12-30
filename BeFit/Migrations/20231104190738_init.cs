using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeFit.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cwiczenia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaCwiczenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObciazenieKg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cwiczenia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Uzytkownicy",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uprawnienia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzytkownicy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SesjaTreningowa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUzytkownika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SesjaTreningowa", x => x.id);
                    table.ForeignKey(
                        name: "FK_SesjaTreningowa_Uzytkownicy_IdUzytkownika",
                        column: x => x.IdUzytkownika,
                        principalTable: "Uzytkownicy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wyniki",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiczbaSerii = table.Column<int>(type: "int", nullable: false),
                    LiczbaPowtorzenWSerii = table.Column<int>(type: "int", nullable: false),
                    IdNazwyCwiczenia = table.Column<int>(type: "int", nullable: false),
                    IdSesjaTreningowa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wyniki", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wyniki_Cwiczenia_IdNazwyCwiczenia",
                        column: x => x.IdNazwyCwiczenia,
                        principalTable: "Cwiczenia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wyniki_SesjaTreningowa_IdSesjaTreningowa",
                        column: x => x.IdSesjaTreningowa,
                        principalTable: "SesjaTreningowa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SesjaTreningowa_IdUzytkownika",
                table: "SesjaTreningowa",
                column: "IdUzytkownika");

            migrationBuilder.CreateIndex(
                name: "IX_Wyniki_IdNazwyCwiczenia",
                table: "Wyniki",
                column: "IdNazwyCwiczenia");

            migrationBuilder.CreateIndex(
                name: "IX_Wyniki_IdSesjaTreningowa",
                table: "Wyniki",
                column: "IdSesjaTreningowa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wyniki");

            migrationBuilder.DropTable(
                name: "Cwiczenia");

            migrationBuilder.DropTable(
                name: "SesjaTreningowa");

            migrationBuilder.DropTable(
                name: "Uzytkownicy");
        }
    }
}
