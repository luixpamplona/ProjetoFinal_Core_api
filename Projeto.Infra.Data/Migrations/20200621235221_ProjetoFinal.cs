using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Infra.Data.Migrations
{
    public partial class ProjetoFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    IdMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Crm = table.Column<string>(maxLength: 150, nullable: false),
                    Especializacao = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.IdMedico);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Telefone = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IdPaciente);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    IdAtendimento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAtendimento = table.Column<DateTime>(type: "date", nullable: false),
                    Local = table.Column<string>(maxLength: 100, nullable: false),
                    Observacoes = table.Column<string>(maxLength: 100, nullable: false),
                    IdMedico = table.Column<int>(nullable: false),
                    IdPaciente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.IdAtendimento);
                    table.ForeignKey(
                        name: "FK_Atendimento_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atendimento_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdMedico",
                table: "Atendimento",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdPaciente",
                table: "Atendimento",
                column: "IdPaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
