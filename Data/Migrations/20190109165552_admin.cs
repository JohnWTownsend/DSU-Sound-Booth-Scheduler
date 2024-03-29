﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AspNetUsers_ReservingUserId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_ReservingUserId",
                table: "Reservation");

            migrationBuilder.AlterColumn<string>(
                name: "ReservingUserId",
                table: "Reservation",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ReservingUserId",
                table: "Reservation",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ReservingUserId",
                table: "Reservation",
                column: "ReservingUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AspNetUsers_ReservingUserId",
                table: "Reservation",
                column: "ReservingUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
