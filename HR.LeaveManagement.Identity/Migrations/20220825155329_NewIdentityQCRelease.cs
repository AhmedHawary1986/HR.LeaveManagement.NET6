using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Identity.Migrations
{
    public partial class NewIdentityQCRelease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c74f86ec-a6d6-4e87-b03d-459836c69050");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "f779402e-204d-4763-85fa-212491d41876");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7568c546-ad4e-49dd-a15f-f39cf1452777", "AQAAAAEAACcQAAAAEIkCegcG2lSjod6QGhTyPmrwHaB0RSgxo5WPgsdcNjqhfSAgbTXmOreha8YFh7OUeA==", "abdcbf14-e7bd-43cf-af10-a8b53e3abfb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5578098b-ebc6-4621-82a3-7d7805d08d86", "AQAAAAEAACcQAAAAEDRDkNJveMeL28bf+cMmdm0EwXnV5wezT2TWTq8nfJIr0oaQcZ2+FaJmTNgwSAV4dg==", "20b3706c-d6ea-4260-8faa-6a37b4924f67" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "68bb5593-dfd4-4951-a3b0-5fe5788ebde4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d11f9641-113b-4d94-9505-35d91cc7f298");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2cedf01-cee0-430a-b820-0c377b586c0a", "AQAAAAEAACcQAAAAEN/+QPuA+uuzTXrdYR7YF0/+JPxiPmjUY/ukh+lBiXnLyMcVGwVaQDSrcginM2gbtA==", "b0bc8cba-dbe5-49c1-b77c-108c1dcccacc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49ff2dd4-d01a-42bb-afb8-83202db83269", "AQAAAAEAACcQAAAAEEnH3am4iXtp/eOTCv2+/TfcX6lIU9iYzudCAZkuGPuPyHjO8/6+fUwUX0kZfjZj3A==", "a039aaef-c811-4cc7-a4e3-42092c879d08" });
        }
    }
}
