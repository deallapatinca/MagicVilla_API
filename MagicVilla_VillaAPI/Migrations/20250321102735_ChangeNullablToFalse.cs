using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNullablToFalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_VillaNumber_VillaID",
                table: "VillaNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VillaNumber",
                table: "VillaNumber");

            migrationBuilder.RenameTable(
                name: "VillaNumber",
                newName: "Villas");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumber",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villas",
                table: "Villas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 21, 11, 27, 34, 484, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 21, 11, 27, 34, 484, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 21, 11, 27, 34, 484, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 21, 11, 27, 34, 484, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 21, 11, 27, 34, 484, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 21, 11, 27, 34, 484, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 21, 11, 27, 34, 484, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumber",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Villas",
                table: "Villas");

            migrationBuilder.RenameTable(
                name: "Villas",
                newName: "VillaNumber");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VillaNumber",
                table: "VillaNumber",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "VillaNumber",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 13, 47, 47, 790, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "VillaNumber",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 13, 47, 47, 790, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "VillaNumber",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 13, 47, 47, 790, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "VillaNumber",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 13, 47, 47, 790, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "VillaNumber",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 13, 47, 47, 790, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "VillaNumber",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 13, 47, 47, 790, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "VillaNumber",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 13, 47, 47, 790, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_VillaNumber_VillaID",
                table: "VillaNumber",
                column: "VillaID",
                principalTable: "VillaNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
