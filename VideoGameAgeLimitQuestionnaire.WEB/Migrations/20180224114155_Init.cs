using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VideoGameAgeLimitQuestionnaire.WEB.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Text = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BinaryQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DeterminateAnswer = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    ResultId = table.Column<int>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinaryQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BinaryQuestions_Results_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MultiAnswersQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Order = table.Column<int>(nullable: false),
                    ResultId = table.Column<int>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiAnswersQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiAnswersQuestions_Results_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IsDeterminateAnswer = table.Column<bool>(nullable: false),
                    MultiAnswersQuestionId = table.Column<int>(nullable: true),
                    Text = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_MultiAnswersQuestions_MultiAnswersQuestionId",
                        column: x => x.MultiAnswersQuestionId,
                        principalTable: "MultiAnswersQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_MultiAnswersQuestionId",
                table: "Answers",
                column: "MultiAnswersQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_BinaryQuestions_ResultId",
                table: "BinaryQuestions",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiAnswersQuestions_ResultId",
                table: "MultiAnswersQuestions",
                column: "ResultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "BinaryQuestions");

            migrationBuilder.DropTable(
                name: "MultiAnswersQuestions");

            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
