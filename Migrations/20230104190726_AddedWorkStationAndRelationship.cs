using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApiDotnet7.Migrations
{
    /// <inheritdoc />
    public partial class AddedWorkStationAndRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkStationId",
                table: "Assets",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkStations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkStations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_WorkStationId",
                table: "Assets",
                column: "WorkStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_WorkStations_WorkStationId",
                table: "Assets",
                column: "WorkStationId",
                principalTable: "WorkStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_WorkStations_WorkStationId",
                table: "Assets");

            migrationBuilder.DropTable(
                name: "WorkStations");

            migrationBuilder.DropIndex(
                name: "IX_Assets_WorkStationId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "WorkStationId",
                table: "Assets");
        }
    }
}
