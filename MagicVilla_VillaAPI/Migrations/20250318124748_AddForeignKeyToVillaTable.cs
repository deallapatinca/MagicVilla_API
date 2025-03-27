using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Villas",
                table: "Villas");

            migrationBuilder.RenameTable(
                name: "Villas",
                newName: "VillaNumber");

            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                //changedddd
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumber",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                //changedddd
                name: "FK_VillaNumbers_VillaNumber_VillaID",
                table: "VillaNumber",
                column: "VillaID",
                principalTable: "VillaNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey( //changedddd
                name: "FK_VillaNumbers_VillaNumber_VillaID",
                table: "VillaNumber");

            migrationBuilder.DropIndex( //changedddd
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VillaNumber",
                table: "VillaNumber");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumber");

            migrationBuilder.RenameTable(
                name: "VillaNumber",
                newName: "Villas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villas",
                table: "Villas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 10, 34, 34, 8, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 10, 34, 34, 8, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 10, 34, 34, 8, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 10, 34, 34, 8, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 10, 34, 34, 8, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 10, 34, 34, 8, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 10, 34, 34, 8, DateTimeKind.Local).AddTicks(3253));
        }
    }
}
