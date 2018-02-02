using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace blog.Migrations
{
    public partial class AddedPostLabelToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLabel_Labels_LabelId",
                table: "PostLabel");

            migrationBuilder.DropForeignKey(
                name: "FK_PostLabel_Posts_PostId",
                table: "PostLabel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostLabel",
                table: "PostLabel");

            migrationBuilder.RenameTable(
                name: "PostLabel",
                newName: "PostLabels");

            migrationBuilder.RenameIndex(
                name: "IX_PostLabel_LabelId",
                table: "PostLabels",
                newName: "IX_PostLabels_LabelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostLabels",
                table: "PostLabels",
                columns: new[] { "PostId", "LabelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostLabels_Labels_LabelId",
                table: "PostLabels",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostLabels_Posts_PostId",
                table: "PostLabels",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLabels_Labels_LabelId",
                table: "PostLabels");

            migrationBuilder.DropForeignKey(
                name: "FK_PostLabels_Posts_PostId",
                table: "PostLabels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostLabels",
                table: "PostLabels");

            migrationBuilder.RenameTable(
                name: "PostLabels",
                newName: "PostLabel");

            migrationBuilder.RenameIndex(
                name: "IX_PostLabels_LabelId",
                table: "PostLabel",
                newName: "IX_PostLabel_LabelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostLabel",
                table: "PostLabel",
                columns: new[] { "PostId", "LabelId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostLabel_Labels_LabelId",
                table: "PostLabel",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostLabel_Posts_PostId",
                table: "PostLabel",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
