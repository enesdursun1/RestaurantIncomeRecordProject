using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DeleteOrderForTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderForTables_OrderForTableId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderForTables");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderForTableId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderForTableId",
                table: "Orders");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Tables",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Tables",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OrderForTableId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderForTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderForTables", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderForTableId",
                table: "Orders",
                column: "OrderForTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderForTables_OrderForTableId",
                table: "Orders",
                column: "OrderForTableId",
                principalTable: "OrderForTables",
                principalColumn: "Id");
        }
    }
}
