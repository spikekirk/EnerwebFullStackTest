using Microsoft.EntityFrameworkCore.Migrations;

namespace Enerweb.FullStackTest.API.Migrations
{
    public partial class FixForeignKeyCascadeDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MeterDataFileDataPeriod_MeterDataFileServicePointId",
                table: "MeterDataFileDataPeriod",
                column: "MeterDataFileServicePointId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeterDataFileDataPeriod_MeterDataFileServicePoint_MeterDataFileServicePointId",
                table: "MeterDataFileDataPeriod",
                column: "MeterDataFileServicePointId",
                principalTable: "MeterDataFileServicePoint",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeterDataFileDataPeriod_MeterDataFileServicePoint_MeterDataFileServicePointId",
                table: "MeterDataFileDataPeriod");

            migrationBuilder.DropIndex(
                name: "IX_MeterDataFileDataPeriod_MeterDataFileServicePointId",
                table: "MeterDataFileDataPeriod");
        }
    }
}
