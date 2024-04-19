using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhilosopherApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class m2mpayloadç : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscussionPhilosopher_Discussions_DiscussionsId",
                table: "DiscussionPhilosopher");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscussionPhilosopher_Philosophers_PhilosophersId",
                table: "DiscussionPhilosopher");

            migrationBuilder.RenameColumn(
                name: "PhilosophersId",
                table: "DiscussionPhilosopher",
                newName: "PhilosopherId");

            migrationBuilder.RenameColumn(
                name: "DiscussionsId",
                table: "DiscussionPhilosopher",
                newName: "DiscussionId");

            migrationBuilder.RenameIndex(
                name: "IX_DiscussionPhilosopher_PhilosophersId",
                table: "DiscussionPhilosopher",
                newName: "IX_DiscussionPhilosopher_PhilosopherId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateJoined",
                table: "DiscussionPhilosopher",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscussionPhilosopher_Discussions_DiscussionId",
                table: "DiscussionPhilosopher",
                column: "DiscussionId",
                principalTable: "Discussions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscussionPhilosopher_Philosophers_PhilosopherId",
                table: "DiscussionPhilosopher",
                column: "PhilosopherId",
                principalTable: "Philosophers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscussionPhilosopher_Discussions_DiscussionId",
                table: "DiscussionPhilosopher");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscussionPhilosopher_Philosophers_PhilosopherId",
                table: "DiscussionPhilosopher");

            migrationBuilder.DropColumn(
                name: "DateJoined",
                table: "DiscussionPhilosopher");

            migrationBuilder.RenameColumn(
                name: "PhilosopherId",
                table: "DiscussionPhilosopher",
                newName: "PhilosophersId");

            migrationBuilder.RenameColumn(
                name: "DiscussionId",
                table: "DiscussionPhilosopher",
                newName: "DiscussionsId");

            migrationBuilder.RenameIndex(
                name: "IX_DiscussionPhilosopher_PhilosopherId",
                table: "DiscussionPhilosopher",
                newName: "IX_DiscussionPhilosopher_PhilosophersId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscussionPhilosopher_Discussions_DiscussionsId",
                table: "DiscussionPhilosopher",
                column: "DiscussionsId",
                principalTable: "Discussions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscussionPhilosopher_Philosophers_PhilosophersId",
                table: "DiscussionPhilosopher",
                column: "PhilosophersId",
                principalTable: "Philosophers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
