using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hospitalBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Especialidad = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "text", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "ApellidoMaterno", "ApellidoPaterno", "Especialidad", "Nombre" },
                values: new object[,]
                {
                    { "123", "Lopez", "Perez", "Pediatra", "Juan" },
                    { "1231", "Duran", "Mercado", "Medico", "Cristian" },
                    { "321", "Redes 2", "Peredo", "Docente", "Roberto" },
                    { "dok1od21kod12", "Pedraza", "Moron", "Cirujano", "Ismael" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}
