using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedTeamMemberToPostType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Name", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8545), "Event", new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8591), "Advertisment", null, new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8595) },
                    { 4, null, new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8598), "TeamMember", null, new DateTime(2020, 8, 18, 8, 8, 57, 96, DateTimeKind.Local).AddTicks(8602) }
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Name", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 17, 11, 24, 58, 965, DateTimeKind.Local).AddTicks(7862), "Advertisment", new DateTime(2020, 8, 17, 11, 24, 58, 965, DateTimeKind.Local).AddTicks(7904) });

         
        }
    }
}
