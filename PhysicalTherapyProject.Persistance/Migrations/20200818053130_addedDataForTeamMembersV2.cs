using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedDataForTeamMembersV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedBy", "CreatedOn", "Date", "PostTypeId", "PostUserId", "Title", "UpdatedBy", "UpdatedOn", "isForAuthenticatedUser" },
                values: new object[,]
                {
                    { 9, "BRIGITA ZACHOVAJEVIENĖ – Kauno kr. pirmininkė 8 698 75901 brigitaz@medi.lt Pareigos: sekretorė", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1145), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1148), false },
                    { 10, "IEVA EGLĖ JAMONTAITĖ  Vilniaus kr.pirmininkė 8 682 45413 ieva.jamontaite@gmail.com Pareigos: LKTD narių narystės tvarkos priežiūra", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1153), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1156), false },
                    { 8, "DOVILĖ VALATKIENĖ –Klaipėdos <b>kr.pirmininkė<b> 861149101 dvalatkiene@yahoo.com klaipedosktd@gmail.com Pareigos: Klaipėdos krašto kineziterapeutų atstovavimas", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1138), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 31, 30, 577, DateTimeKind.Local).AddTicks(1141), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
