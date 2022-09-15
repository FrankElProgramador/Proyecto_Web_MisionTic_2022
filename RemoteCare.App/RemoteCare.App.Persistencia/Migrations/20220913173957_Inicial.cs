using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteCare.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HisClinic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Veterinario = table.Column<int>(type: "int", nullable: false),
                    ID_Dueño = table.Column<int>(type: "int", nullable: false),
                    ID_Oveja = table.Column<int>(type: "int", nullable: false),
                    ID_Visita = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HisClinic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "oveja",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Veterinario_Asignado = table.Column<int>(type: "int", nullable: false),
                    Dueño_Asignado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oveja", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certificado = table.Column<int>(type: "int", nullable: true),
                    Tarjeta_profesional = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "visita",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Frecuencia_Respiratoria = table.Column<float>(type: "real", nullable: false),
                    Frecuencia_Cardiaca = table.Column<float>(type: "real", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_Veterinario = table.Column<int>(type: "int", nullable: false),
                    Medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visita", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HisClinic");

            migrationBuilder.DropTable(
                name: "oveja");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "visita");
        }
    }
}
