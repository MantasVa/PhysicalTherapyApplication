using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    public partial class addedDataForTeamMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedBy", "CreatedOn", "Date", "PostTypeId", "PostUserId", "Title", "UpdatedBy", "UpdatedOn", "isForAuthenticatedUser" },
                values: new object[,]
                {
                    { 6, "Prezidentė: INESA RIMDEIKIENĖ 861112265 inesa.rimdeikiene@kaunoklinikos.lt Pareigos: draugijos valdybos ir narių atstovavimas, bendravimas su valstybinėmis institucijomis", null, new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6430), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6433), false },
                    { 7, "RAIMUNDAS VENSKAITIS 862237888 raimundas.venskaitis@gmail.com Pareigos:  draugijos internetinio puslapio ir Facebook paskyros valdymas ir priežiūra", null, new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6438), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "Where can I get some?", null, new DateTime(2020, 8, 18, 8, 27, 2, 96, DateTimeKind.Local).AddTicks(6441), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Occupation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(1257), new DateTime(2020, 8, 18, 8, 8, 57, 98, DateTimeKind.Local).AddTicks(1271) });
        }
    }
}
