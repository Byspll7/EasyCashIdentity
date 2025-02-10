using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentity.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_electricbills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountID",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ElectricBills",
                columns: table => new
                {
                    ElectricBillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricBills", x => x.ElectricBillId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_CustomerAccountID",
                table: "CustomerAccountProcesses",
                column: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_CustomerAccountID",
                table: "CustomerAccountProcesses",
                column: "CustomerAccountID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_CustomerAccountID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropTable(
                name: "ElectricBills");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_CustomerAccountID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "CustomerAccountID",
                table: "CustomerAccountProcesses");
        }
    }
}
