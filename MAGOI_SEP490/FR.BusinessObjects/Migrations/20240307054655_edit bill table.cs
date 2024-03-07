using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class editbilltable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedbackId",
                table: "Bills");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FeedbackId",
                table: "Bills",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
