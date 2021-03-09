using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class AddedEventPriceToPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EventPrice",
                table: "Posts",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "UpdatedOn" },
                values: new object[] { "4921241c-656f-4ba2-b80a-4a4bb3005830", new DateTime(2020, 10, 19, 18, 40, 47, 138, DateTimeKind.Local).AddTicks(1350), new DateTime(2020, 10, 19, 18, 40, 47, 138, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "UpdatedOn" },
                values: new object[] { "0c9e83bc-bab1-4d77-9a47-ef15d3551daa", new DateTime(2020, 10, 19, 18, 40, 47, 138, DateTimeKind.Local).AddTicks(7195), new DateTime(2020, 10, 19, 18, 40, 47, 138, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "UpdatedOn" },
                values: new object[] { "88ebca37-15a3-4063-b795-7430a629d405", new DateTime(2020, 10, 19, 18, 40, 47, 138, DateTimeKind.Local).AddTicks(7368), new DateTime(2020, 10, 19, 18, 40, 47, 138, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(6506), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(7279), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(7311), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 130, DateTimeKind.Local).AddTicks(707), new DateTime(2020, 10, 19, 18, 40, 47, 134, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 135, DateTimeKind.Local).AddTicks(1435), new DateTime(2020, 10, 19, 18, 40, 47, 135, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 135, DateTimeKind.Local).AddTicks(1548), new DateTime(2020, 10, 19, 18, 40, 47, 135, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 135, DateTimeKind.Local).AddTicks(1561), new DateTime(2020, 10, 19, 18, 40, 47, 135, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 136, DateTimeKind.Local).AddTicks(9497), new DateTime(2020, 10, 19, 18, 40, 47, 136, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5185), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5281), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5293), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5302), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5311), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5319), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5327), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5336), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5345), new DateTime(2020, 10, 19, 18, 40, 47, 137, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 138, DateTimeKind.Local).AddTicks(9067), new DateTime(2020, 10, 19, 18, 40, 47, 138, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 139, DateTimeKind.Local).AddTicks(454), new DateTime(2020, 10, 19, 18, 40, 47, 139, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 139, DateTimeKind.Local).AddTicks(543), new DateTime(2020, 10, 19, 18, 40, 47, 139, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 18, 40, 47, 139, DateTimeKind.Local).AddTicks(585), new DateTime(2020, 10, 19, 18, 40, 47, 139, DateTimeKind.Local).AddTicks(605) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventPrice",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "UpdatedOn" },
                values: new object[] { "6fcb146a-259b-408a-a5ec-9557cd611cc1", new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(2879), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "UpdatedOn" },
                values: new object[] { "2cf0fc17-aba8-4cc8-b31c-3065b43728da", new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(4830), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "UpdatedOn" },
                values: new object[] { "285dc707-abaa-4f66-b345-39b931c9d177", new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(4872), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(9738), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(227), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(253), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 700, DateTimeKind.Local).AddTicks(3158), new DateTime(2020, 10, 19, 13, 4, 19, 703, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 703, DateTimeKind.Local).AddTicks(1716), new DateTime(2020, 10, 19, 13, 4, 19, 703, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 703, DateTimeKind.Local).AddTicks(1767), new DateTime(2020, 10, 19, 13, 4, 19, 703, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 703, DateTimeKind.Local).AddTicks(1775), new DateTime(2020, 10, 19, 13, 4, 19, 703, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(5216), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8758), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8841), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8851), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8859), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8867), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8875), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8882), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8891), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8899), new DateTime(2020, 10, 19, 13, 4, 19, 704, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(5651), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(6137), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(6161), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(6168), new DateTime(2020, 10, 19, 13, 4, 19, 705, DateTimeKind.Local).AddTicks(6172) });
        }
    }
}
