using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SociosClubApp.Data.Migrations
{
    public partial class Socio01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    SocioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    Celular = table.Column<string>(nullable: false),
                    Fax = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    FechaNac = table.Column<DateTime>(nullable: false),
                    TipoMembresia = table.Column<int>(nullable: false),
                    LugarTrabajo = table.Column<string>(nullable: true),
                    DireccionOficina = table.Column<string>(nullable: true),
                    TelefonoOficina = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    FechaSalida = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.SocioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socios");
        }
    }
}
