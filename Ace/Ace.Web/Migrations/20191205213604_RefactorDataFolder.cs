using Microsoft.EntityFrameworkCore.Migrations;

namespace Ace.Web.Migrations
{
    public partial class RefactorDataFolder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StepContact_Contacts_ContactId",
                table: "StepContact");

            migrationBuilder.DropForeignKey(
                name: "FK_StepContact_Steps_StepId",
                table: "StepContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Steps",
                table: "Steps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.EnsureSchema(
                name: "BallotTrack");

            migrationBuilder.RenameTable(
                name: "StepContact",
                newName: "StepContact",
                newSchema: "BallotTrack");

            migrationBuilder.RenameTable(
                name: "Steps",
                newName: "Step",
                newSchema: "BallotTrack");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact",
                newSchema: "BallotTrack");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Step",
                schema: "BallotTrack",
                table: "Step",
                column: "StepId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                schema: "BallotTrack",
                table: "Contact",
                column: "ContactId");

            migrationBuilder.InsertData(
                schema: "BallotTrack",
                table: "Contact",
                columns: new[] { "ContactId", "FullName", "IsPrimary", "PhoneNbr" },
                values: new object[,]
                {
                    { 1, "Kristen Williams", true, "262-4528" },
                    { 2, "Megan Rosenberger", true, "256-3245" },
                    { 3, "Irene Settle", false, "4955896" },
                    { 4, "Whitney Juszczak", true, "261-8839" },
                    { 5, "Monica Figueroa", false, "261-8839" },
                    { 6, "Ben Lane", true, "262-6814" },
                    { 7, "Elizabeth Martin Parker", false, "261-8749" }
                });

            migrationBuilder.InsertData(
                schema: "BallotTrack",
                table: "Step",
                columns: new[] { "StepId", "StepName" },
                values: new object[,]
                {
                    { 1, "Mail Room" },
                    { 2, "Early Voting" },
                    { 3, "Early Ballot Board Verification" },
                    { 4, "Early Ballot Board Ins Ctrl Brd" },
                    { 5, "Tabulation" },
                    { 6, "Completed to Vault" },
                    { 7, "Vault Hold" }
                });

            migrationBuilder.InsertData(
                schema: "BallotTrack",
                table: "StepContact",
                columns: new[] { "StepContactId", "ContactId", "StepId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 3, 2 },
                    { 4, 4, 3 },
                    { 5, 5, 3 },
                    { 6, 4, 4 },
                    { 7, 5, 4 },
                    { 8, 6, 5 },
                    { 9, 7, 5 },
                    { 10, 1, 6 },
                    { 11, 3, 6 },
                    { 12, 1, 7 },
                    { 13, 3, 7 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StepContact_Contact_ContactId",
                schema: "BallotTrack",
                table: "StepContact",
                column: "ContactId",
                principalSchema: "BallotTrack",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StepContact_Step_StepId",
                schema: "BallotTrack",
                table: "StepContact",
                column: "StepId",
                principalSchema: "BallotTrack",
                principalTable: "Step",
                principalColumn: "StepId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StepContact_Contact_ContactId",
                schema: "BallotTrack",
                table: "StepContact");

            migrationBuilder.DropForeignKey(
                name: "FK_StepContact_Step_StepId",
                schema: "BallotTrack",
                table: "StepContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Step",
                schema: "BallotTrack",
                table: "Step");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                schema: "BallotTrack",
                table: "Contact");

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "StepContact",
                keyColumn: "StepContactId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "BallotTrack",
                table: "Step",
                keyColumn: "StepId",
                keyValue: 7);

            migrationBuilder.RenameTable(
                name: "StepContact",
                schema: "BallotTrack",
                newName: "StepContact");

            migrationBuilder.RenameTable(
                name: "Step",
                schema: "BallotTrack",
                newName: "Steps");

            migrationBuilder.RenameTable(
                name: "Contact",
                schema: "BallotTrack",
                newName: "Contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Steps",
                table: "Steps",
                column: "StepId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_StepContact_Contacts_ContactId",
                table: "StepContact",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StepContact_Steps_StepId",
                table: "StepContact",
                column: "StepId",
                principalTable: "Steps",
                principalColumn: "StepId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
