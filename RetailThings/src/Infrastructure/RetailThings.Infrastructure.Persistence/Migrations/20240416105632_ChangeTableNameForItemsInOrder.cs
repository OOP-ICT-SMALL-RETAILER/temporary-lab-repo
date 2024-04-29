// <copyright file="20240416105632_ChangeTableNameForItemsInOrder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore.Migrations;
#pragma warning disable

#nullable disable

namespace RetailThings.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableNameForItemsInOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOrders_Items_ItemId",
                table: "InOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_InOrders_Orders_OrderId",
                table: "InOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InOrders",
                table: "InOrders");

            migrationBuilder.RenameTable(
                name: "InOrders",
                newName: "ItemInOrders");

            migrationBuilder.RenameIndex(
                name: "IX_InOrders_OrderId",
                table: "ItemInOrders",
                newName: "IX_ItemInOrders_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_InOrders_ItemId",
                table: "ItemInOrders",
                newName: "IX_ItemInOrders_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemInOrders",
                table: "ItemInOrders",
                column: "ItemInOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemInOrders_Items_ItemId",
                table: "ItemInOrders",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemInOrders_Orders_OrderId",
                table: "ItemInOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemInOrders_Items_ItemId",
                table: "ItemInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemInOrders_Orders_OrderId",
                table: "ItemInOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemInOrders",
                table: "ItemInOrders");

            migrationBuilder.RenameTable(
                name: "ItemInOrders",
                newName: "InOrders");

            migrationBuilder.RenameIndex(
                name: "IX_ItemInOrders_OrderId",
                table: "InOrders",
                newName: "IX_InOrders_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemInOrders_ItemId",
                table: "InOrders",
                newName: "IX_InOrders_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InOrders",
                table: "InOrders",
                column: "ItemInOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_InOrders_Items_ItemId",
                table: "InOrders",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InOrders_Orders_OrderId",
                table: "InOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
