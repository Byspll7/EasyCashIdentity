﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentity.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_cust_process : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_ReceiverId",
                table: "CustomerAccountProcesses",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_SenderId",
                table: "CustomerAccountProcesses",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverId",
                table: "CustomerAccountProcesses",
                column: "ReceiverId",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderId",
                table: "CustomerAccountProcesses",
                column: "SenderId",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_ReceiverId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_SenderId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "CustomerAccountProcesses");
        }
    }
}
