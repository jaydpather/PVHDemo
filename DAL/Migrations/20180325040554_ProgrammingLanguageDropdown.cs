using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class ProgrammingLanguageDropdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgrammingLanguage",
                table: "Registrations");

            migrationBuilder.AddColumn<int>(
                name: "ProgrammingLanguageId",
                table: "Registrations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguagesMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguagesMaster", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ProgrammingLanguageId",
                table: "Registrations",
                column: "ProgrammingLanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_ProgrammingLanguagesMaster_ProgrammingLanguageId",
                table: "Registrations",
                column: "ProgrammingLanguageId",
                principalTable: "ProgrammingLanguagesMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            //todo: find a way of inserting static data in migration. Couldn't do this with DropDatabaseIfModelChanges (Initializer / seed method).
            //migrationBuilder.InsertData("ProgrammingLanguageMaster", new string[] { "Name" }, new string[] { "C#", "VB.Net", "Java", "Javascript" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_ProgrammingLanguagesMaster_ProgrammingLanguageId",
                table: "Registrations");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguagesMaster");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_ProgrammingLanguageId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "ProgrammingLanguageId",
                table: "Registrations");

            migrationBuilder.AddColumn<string>(
                name: "ProgrammingLanguage",
                table: "Registrations",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
