using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BBS.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LoginTime = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    role_name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    pass = table.Column<int>(type: "int", nullable: false),
                    reg_name = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "role_info",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LoginTime = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    sex = table.Column<int>(type: "int", nullable: false),
                    lvl = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(13)", nullable: false),
                    rid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_info", x => x.ID);
                    table.ForeignKey(
                        name: "FK_role_info_role_rid",
                        column: x => x.rid,
                        principalTable: "role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_role_info_rid",
                table: "role_info",
                column: "rid",
                unique: true,
                filter: "[rid] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "role_info");

            migrationBuilder.DropTable(
                name: "role");
        }
    }
}
