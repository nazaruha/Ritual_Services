using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibContext.Migrations
{
    public partial class addtblServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEng = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    NameUkr = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblServices_tblServicesTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "tblServicesTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblServices_ServiceTypeId",
                table: "tblServices",
                column: "ServiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblServices");
        }
    }
}
