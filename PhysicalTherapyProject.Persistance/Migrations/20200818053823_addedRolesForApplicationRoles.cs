using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedRolesForApplicationRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.DeleteData(
             table: "AspNetRoles",
             keyColumn: "Id",
             keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                   table: "AspNetRoles",
                   columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                   values: new object[] { 1, "922c23aa-e6eb-4f76-b802-4cafdbaba03e", "Administrator", null });
        }
    }
}
