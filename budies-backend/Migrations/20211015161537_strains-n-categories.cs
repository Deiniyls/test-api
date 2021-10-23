using Microsoft.EntityFrameworkCore.Migrations;

namespace budies_backend.Migrations
{
    public partial class strainsncategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Strains_Effect_EffectsID",
                table: "Strains");

            migrationBuilder.DropTable(
                name: "Effect");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Strains",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Strains",
                newName: "description");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Strains",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "Strains",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Strains",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AilmentsID",
                table: "Strains",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlavorID",
                table: "Strains",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "Strains",
                type: "float",
                maxLength: 5,
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Ailments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ailments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Flavors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flavors", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Strains_AilmentsID",
                table: "Strains",
                column: "AilmentsID");

            migrationBuilder.CreateIndex(
                name: "IX_Strains_FlavorID",
                table: "Strains",
                column: "FlavorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Strains_Ailments",
                table: "Strains",
                column: "AilmentsID",
                principalTable: "Ailments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Strains_Effects",
                table: "Strains",
                column: "EffectsID",
                principalTable: "Effects",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Strains_Flavors",
                table: "Strains",
                column: "FlavorID",
                principalTable: "Flavors",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Strains_Ailments",
                table: "Strains");

            migrationBuilder.DropForeignKey(
                name: "FK_Strains_Effects",
                table: "Strains");

            migrationBuilder.DropForeignKey(
                name: "FK_Strains_Flavors",
                table: "Strains");

            migrationBuilder.DropTable(
                name: "Ailments");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Flavors");

            migrationBuilder.DropIndex(
                name: "IX_Strains_AilmentsID",
                table: "Strains");

            migrationBuilder.DropIndex(
                name: "IX_Strains_FlavorID",
                table: "Strains");

            migrationBuilder.DropColumn(
                name: "AilmentsID",
                table: "Strains");

            migrationBuilder.DropColumn(
                name: "FlavorID",
                table: "Strains");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Strains");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Strains",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Strains",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Strains",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Strains",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Strains",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Effect",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effect", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Strains_Effect_EffectsID",
                table: "Strains",
                column: "EffectsID",
                principalTable: "Effect",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
