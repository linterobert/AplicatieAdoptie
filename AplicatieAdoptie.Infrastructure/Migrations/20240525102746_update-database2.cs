using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicatieAdoptie.Infrastructure.Migrations
{
    public partial class updatedatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VetVisit_Animal_AnimalId",
                table: "VetVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_VetVisit_VetClinic_VetClinicId",
                table: "VetVisit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VetVisit",
                table: "VetVisit");

            migrationBuilder.RenameTable(
                name: "VetVisit",
                newName: "VetVisits");

            migrationBuilder.RenameIndex(
                name: "IX_VetVisit_VetClinicId",
                table: "VetVisits",
                newName: "IX_VetVisits_VetClinicId");

            migrationBuilder.RenameIndex(
                name: "IX_VetVisit_AnimalId",
                table: "VetVisits",
                newName: "IX_VetVisits_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VetVisits",
                table: "VetVisits",
                column: "VetVisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_VetVisits_Animal_AnimalId",
                table: "VetVisits",
                column: "AnimalId",
                principalTable: "Animal",
                principalColumn: "AnimalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VetVisits_VetClinic_VetClinicId",
                table: "VetVisits",
                column: "VetClinicId",
                principalTable: "VetClinic",
                principalColumn: "VetClinicId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VetVisits_Animal_AnimalId",
                table: "VetVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_VetVisits_VetClinic_VetClinicId",
                table: "VetVisits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VetVisits",
                table: "VetVisits");

            migrationBuilder.RenameTable(
                name: "VetVisits",
                newName: "VetVisit");

            migrationBuilder.RenameIndex(
                name: "IX_VetVisits_VetClinicId",
                table: "VetVisit",
                newName: "IX_VetVisit_VetClinicId");

            migrationBuilder.RenameIndex(
                name: "IX_VetVisits_AnimalId",
                table: "VetVisit",
                newName: "IX_VetVisit_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VetVisit",
                table: "VetVisit",
                column: "VetVisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_VetVisit_Animal_AnimalId",
                table: "VetVisit",
                column: "AnimalId",
                principalTable: "Animal",
                principalColumn: "AnimalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VetVisit_VetClinic_VetClinicId",
                table: "VetVisit",
                column: "VetClinicId",
                principalTable: "VetClinic",
                principalColumn: "VetClinicId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
