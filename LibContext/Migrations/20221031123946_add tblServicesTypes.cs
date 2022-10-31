using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibContext.Migrations
{
    public partial class addtblServicesTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblServicesTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameUkr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblServicesTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblServicesTypes");
        }
    }
}
