using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class edit_init_tableid_value : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("24421c43-7ce9-49f9-b279-545130db8777"),
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("72d44212-da44-4735-9846-af8e859c2086"),
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9e4241f8-ad17-48c4-8f49-9bb8607285c4"),
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"),
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("a6c5a1d6-1942-48fc-9eca-1b5e9499ba6d"),
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b9da28be-79af-4258-8cd7-c608c5fa2d8c"),
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("cca0bf6c-af6e-4c37-8636-db7a562bb57e"),
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f63c6d7a-7d37-4a06-a80c-a311424eac59"),
                column: "StatusId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("24421c43-7ce9-49f9-b279-545130db8777"),
                column: "StatusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("72d44212-da44-4735-9846-af8e859c2086"),
                column: "StatusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9e4241f8-ad17-48c4-8f49-9bb8607285c4"),
                column: "StatusId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"),
                column: "StatusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("a6c5a1d6-1942-48fc-9eca-1b5e9499ba6d"),
                column: "StatusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b9da28be-79af-4258-8cd7-c608c5fa2d8c"),
                column: "StatusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("cca0bf6c-af6e-4c37-8636-db7a562bb57e"),
                column: "StatusId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f63c6d7a-7d37-4a06-a80c-a311424eac59"),
                column: "StatusId",
                value: 3);
        }
    }
}
