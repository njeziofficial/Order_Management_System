using Microsoft.EntityFrameworkCore.Migrations;

namespace OMS.Persistence.Migrations
{
    public partial class RemovedProductIDfromTransactiontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Orders_OrderID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_OrderID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TransactionStatus",
                table: "Transactions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransactionStatus",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OrderID",
                table: "Transactions",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Orders_OrderID",
                table: "Transactions",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
