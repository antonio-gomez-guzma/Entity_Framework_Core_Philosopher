using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhilosopherApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class manytomanysimple : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discussions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscussionPhilosopher",
                columns: table => new
                {
                    DiscussionsId = table.Column<int>(type: "int", nullable: false),
                    PhilosophersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscussionPhilosopher", x => new { x.DiscussionsId, x.PhilosophersId });
                    table.ForeignKey(
                        name: "FK_DiscussionPhilosopher_Discussions_DiscussionsId",
                        column: x => x.DiscussionsId,
                        principalTable: "Discussions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscussionPhilosopher_Philosophers_PhilosophersId",
                        column: x => x.PhilosophersId,
                        principalTable: "Philosophers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionPhilosopher_PhilosophersId",
                table: "DiscussionPhilosopher",
                column: "PhilosophersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscussionPhilosopher");

            migrationBuilder.DropTable(
                name: "Discussions");
        }
    }
}
