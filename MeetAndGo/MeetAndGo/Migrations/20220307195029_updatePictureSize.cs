using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetAndGo.Migrations
{
    public partial class updatePictureSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Picture",
                table: "Office",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Picture",
                table: "Building",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(2000)",
                oldMaxLength: 2000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Picture",
                table: "Office",
                type: "varbinary(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(byte[]));

            migrationBuilder.AlterColumn<byte[]>(
                name: "Picture",
                table: "Building",
                type: "varbinary(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(byte[]));
        }
    }
}
