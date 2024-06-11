﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_GP.Data.Migrations
{
    /// <inheritdoc />
    public partial class update_categoryId_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prodcuts_Categories_CategoryId",
                table: "Prodcuts");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Prodcuts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Prodcuts_Categories_CategoryId",
                table: "Prodcuts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prodcuts_Categories_CategoryId",
                table: "Prodcuts");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Prodcuts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prodcuts_Categories_CategoryId",
                table: "Prodcuts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
