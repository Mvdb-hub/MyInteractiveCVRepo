using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InteractiveCvWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbilityCategory",
                columns: table => new
                {
                    AbilityCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityCategory", x => x.AbilityCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    AboutMe = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: false),
                    TwitterUrl = table.Column<string>(maxLength: 150, nullable: true),
                    LinkedInUrl = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PersonAbility",
                columns: table => new
                {
                    PersonAbilityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(nullable: false),
                    AbilityCategoryID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAbility", x => x.PersonAbilityID);
                    table.ForeignKey(
                        name: "FK_PersonAbility_AbilityCategory_AbilityCategoryID",
                        column: x => x.AbilityCategoryID,
                        principalTable: "AbilityCategory",
                        principalColumn: "AbilityCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonAbility_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonEducation",
                columns: table => new
                {
                    PersonEducationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(nullable: false),
                    SchoolName = table.Column<string>(maxLength: 150, nullable: false),
                    Course = table.Column<string>(maxLength: 150, nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEducation", x => x.PersonEducationID);
                    table.ForeignKey(
                        name: "FK_PersonEducation_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonExperience",
                columns: table => new
                {
                    PersonExperienceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 150, nullable: false),
                    Function = table.Column<string>(maxLength: 150, nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    WebsiteUrl = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonExperience", x => x.PersonExperienceID);
                    table.ForeignKey(
                        name: "FK_PersonExperience_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonAbility_AbilityCategoryID",
                table: "PersonAbility",
                column: "AbilityCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAbility_PersonID",
                table: "PersonAbility",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonEducation_PersonID",
                table: "PersonEducation",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonExperience_PersonID",
                table: "PersonExperience",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonAbility");

            migrationBuilder.DropTable(
                name: "PersonEducation");

            migrationBuilder.DropTable(
                name: "PersonExperience");

            migrationBuilder.DropTable(
                name: "AbilityCategory");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
