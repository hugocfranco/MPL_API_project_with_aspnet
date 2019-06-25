using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mpl.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advogados_Areas_AreasId",
                table: "Advogados");

            migrationBuilder.DropForeignKey(
                name: "FK_Escritorios_Areas_AreasId",
                table: "Escritorios");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Escritorios",
                table: "Escritorios");

            migrationBuilder.DropIndex(
                name: "IX_Escritorios_AreasId",
                table: "Escritorios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advogados",
                table: "Advogados");

            migrationBuilder.DropIndex(
                name: "IX_Advogados_AreasId",
                table: "Advogados");

            migrationBuilder.DropColumn(
                name: "AreasId",
                table: "Escritorios");

            migrationBuilder.DropColumn(
                name: "AreasId",
                table: "Advogados");

            migrationBuilder.RenameTable(
                name: "Escritorios",
                newName: "Escritorio");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "Advogados",
                newName: "Advogado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Escritorio",
                newName: "EscritorioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Advogado",
                newName: "AdvogadoId");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Escritorio",
                type: "varchar(120)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Escritorio",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Escritorio",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Cliente",
                type: "varchar(120)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Advogado",
                type: "varchar(120)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Advogado",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Advogado",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Escritorio",
                table: "Escritorio",
                column: "EscritorioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advogado",
                table: "Advogado",
                column: "AdvogadoId");

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descrição = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "AdvArea",
                columns: table => new
                {
                    AdvogadoId = table.Column<int>(nullable: false),
                    AreaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvArea", x => new { x.AdvogadoId, x.AreaId });
                    table.ForeignKey(
                        name: "FK_AdvArea_Advogado_AdvogadoId",
                        column: x => x.AdvogadoId,
                        principalTable: "Advogado",
                        principalColumn: "AdvogadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvArea_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EscArea",
                columns: table => new
                {
                    EscritorioId = table.Column<int>(nullable: false),
                    AreaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EscArea", x => new { x.EscritorioId, x.AreaId });
                    table.ForeignKey(
                        name: "FK_EscArea_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EscArea_Escritorio_EscritorioId",
                        column: x => x.EscritorioId,
                        principalTable: "Escritorio",
                        principalColumn: "EscritorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvArea_AreaId",
                table: "AdvArea",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_EscArea_AreaId",
                table: "EscArea",
                column: "AreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvArea");

            migrationBuilder.DropTable(
                name: "EscArea");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Escritorio",
                table: "Escritorio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advogado",
                table: "Advogado");

            migrationBuilder.RenameTable(
                name: "Escritorio",
                newName: "Escritorios");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "Advogado",
                newName: "Advogados");

            migrationBuilder.RenameColumn(
                name: "EscritorioId",
                table: "Escritorios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AdvogadoId",
                table: "Advogados",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Escritorios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Escritorios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Escritorios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddColumn<int>(
                name: "AreasId",
                table: "Escritorios",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Advogados",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Advogados",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Advogados",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddColumn<int>(
                name: "AreasId",
                table: "Advogados",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Escritorios",
                table: "Escritorios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advogados",
                table: "Advogados",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Escritorios_AreasId",
                table: "Escritorios",
                column: "AreasId");

            migrationBuilder.CreateIndex(
                name: "IX_Advogados_AreasId",
                table: "Advogados",
                column: "AreasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advogados_Areas_AreasId",
                table: "Advogados",
                column: "AreasId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Escritorios_Areas_AreasId",
                table: "Escritorios",
                column: "AreasId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
