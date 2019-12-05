using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ace.Web.Migrations
{
    public partial class StepsCompletedMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllowToGoBackStep",
                schema: "BallotTrack",
                table: "Step",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BoxCheckInRequired",
                schema: "BallotTrack",
                table: "Step",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "BallotTrack",
                table: "Step",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                schema: "BallotTrack",
                table: "Step",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                schema: "BallotTrack",
                table: "Step",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DefaultNextStep",
                schema: "BallotTrack",
                table: "Step",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBoxEntryStep",
                schema: "BallotTrack",
                table: "Step",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "BallotTrack",
                table: "Step",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PrefillBallotCount",
                schema: "BallotTrack",
                table: "Step",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VaultHoldIsAvailable",
                schema: "BallotTrack",
                table: "Step",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Alice Cooper", "555-1200" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Michael Bruce", "555-1201" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Neal Smith", "555-1202" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 4,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Dennis Dunaway", "555-1203" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 5,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Glen Buxton", "555-1203" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 6,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Mr Nice Guy", "555-1204" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 7,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Vincent Damon Furnier", "555-1205" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateModified", "DefaultNextStep", "IsBoxEntryStep", "ModifiedBy", "PrefillBallotCount" },
                values: new object[] { "073098", new DateTime(2019, 12, 5, 15, 43, 17, 316, DateTimeKind.Local).AddTicks(2710), new DateTime(2019, 12, 5, 15, 43, 17, 318, DateTimeKind.Local).AddTicks(8762), 2, true, "077471", true });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 2,
                columns: new[] { "BoxCheckInRequired", "CreatedBy", "DateCreated", "DateModified", "DefaultNextStep", "IsBoxEntryStep", "ModifiedBy", "PrefillBallotCount", "VaultHoldIsAvailable" },
                values: new object[] { true, "077471", new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2364), new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2390), 3, true, "077471", true, true });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 3,
                columns: new[] { "BoxCheckInRequired", "CreatedBy", "DateCreated", "DateModified", "DefaultNextStep", "ModifiedBy", "VaultHoldIsAvailable" },
                values: new object[] { true, "077471", new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2521), new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2523), 4, "077471", true });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 4,
                columns: new[] { "BoxCheckInRequired", "CreatedBy", "DateCreated", "DateModified", "DefaultNextStep", "ModifiedBy", "VaultHoldIsAvailable" },
                values: new object[] { true, "077471", new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2544), new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2545), 5, "077471", true });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 5,
                columns: new[] { "BoxCheckInRequired", "CreatedBy", "DateCreated", "DateModified", "DefaultNextStep", "ModifiedBy", "VaultHoldIsAvailable" },
                values: new object[] { true, "077471", new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2563), new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2564), 6, "077471", true });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 6,
                columns: new[] { "AllowToGoBackStep", "BoxCheckInRequired", "CreatedBy", "DateCreated", "DateModified", "DefaultNextStep", "ModifiedBy" },
                values: new object[] { true, true, "077471", new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2587), new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2589), 6, "077471" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 7,
                columns: new[] { "BoxCheckInRequired", "CreatedBy", "DateCreated", "DateModified", "ModifiedBy" },
                values: new object[] { true, "073098", new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2606), new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2607), "073098" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowToGoBackStep",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "BoxCheckInRequired",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "DateModified",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "DefaultNextStep",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "IsBoxEntryStep",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "PrefillBallotCount",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropColumn(
                name: "VaultHoldIsAvailable",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Kristen Williams", "262-4528" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Megan Rosenberger", "256-3245" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Irene Settle", "4955896" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 4,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Whitney Juszczak", "261-8839" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 5,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Monica Figueroa", "261-8839" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 6,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Ben Lane", "262-6814" });

            migrationBuilder.UpdateData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 7,
                columns: new[] { "FullName", "PhoneNbr" },
                values: new object[] { "Elizabeth Martin Parker", "261-8749" });
        }
    }
}
