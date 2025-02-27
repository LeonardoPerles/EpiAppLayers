using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpiApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Epi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ca = table.Column<string>(type: "varchar(100)", nullable: true),
                    ValidadeCa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrazoTroca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuncionarioEpi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    EpiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionarioEpi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuncionarioEpi_Epi_EpiId",
                        column: x => x.EpiId,
                        principalTable: "Epi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FuncionarioEpi_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpiSetor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEpi = table.Column<int>(type: "int", nullable: false),
                    EpiId = table.Column<int>(type: "int", nullable: true),
                    IdSetor = table.Column<int>(type: "int", nullable: false),
                    SetorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpiSetor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EpiSetor_Epi_EpiId",
                        column: x => x.EpiId,
                        principalTable: "Epi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpiSetor_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuncionarioSetor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    SetorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionarioSetor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuncionarioSetor_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FuncionarioSetor_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EpiSetor_EpiId",
                table: "EpiSetor",
                column: "EpiId");

            migrationBuilder.CreateIndex(
                name: "IX_EpiSetor_SetorId",
                table: "EpiSetor",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioEpi_EpiId",
                table: "FuncionarioEpi",
                column: "EpiId");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioEpi_FuncionarioId",
                table: "FuncionarioEpi",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioSetor_FuncionarioId",
                table: "FuncionarioSetor",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioSetor_SetorId",
                table: "FuncionarioSetor",
                column: "SetorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EpiSetor");

            migrationBuilder.DropTable(
                name: "FuncionarioEpi");

            migrationBuilder.DropTable(
                name: "FuncionarioSetor");

            migrationBuilder.DropTable(
                name: "Epi");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Setor");
        }
    }
}
