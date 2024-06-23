    using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
namespace Paginas_Enchiladas.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) //Metodo para creacion de la tabla de la base de datos
        {
            migrationBuilder.CreateTable(
                name: "Enchiladas",
                columns: table => new
                {
                    id_Enchilada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_tortilla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relleno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salsa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enchiladas", x => x.id_Enchilada);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) //Metodo para eliminar tabla
        {
            migrationBuilder.DropTable(
                name: "Enchiladas");
        }
    }
}
