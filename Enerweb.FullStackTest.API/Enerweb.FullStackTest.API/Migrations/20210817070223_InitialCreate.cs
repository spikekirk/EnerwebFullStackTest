using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Enerweb.FullStackTest.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeterDataFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "varchar(255)", nullable: true),
                    UploadedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileContents = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterDataFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeterDataFileHeader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeterDataFileId = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "varchar(5)", nullable: true),
                    UserId = table.Column<string>(type: "varchar(12)", nullable: true),
                    FileType = table.Column<string>(type: "varchar(5)", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterDataFileHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterDataFileHeader_MeterDataFile_MeterDataFileId",
                        column: x => x.MeterDataFileId,
                        principalTable: "MeterDataFile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeterDataFileTrailer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeterDataFileId = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "varchar(5)", nullable: true),
                    RecordCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterDataFileTrailer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterDataFileTrailer_MeterDataFile_MeterDataFileId",
                        column: x => x.MeterDataFileId,
                        principalTable: "MeterDataFile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeterDataFileOperatingDate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeterDataFileHeaderId = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "varchar(5)", nullable: true),
                    OperatingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterDataFileOperatingDate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterDataFileOperatingDate_MeterDataFileHeader_MeterDataFileHeaderId",
                        column: x => x.MeterDataFileHeaderId,
                        principalTable: "MeterDataFileHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeterDataFileServicePoint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeterDataFileHeaderId = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "varchar(5)", nullable: true),
                    MeterId = table.Column<string>(type: "varchar(20)", nullable: true),
                    MeterSerialNumber = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterDataFileServicePoint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterDataFileServicePoint_MeterDataFileHeader_MeterDataFileHeaderId",
                        column: x => x.MeterDataFileHeaderId,
                        principalTable: "MeterDataFileHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeterDataFileDataPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeterDataFileOperatingDateId = table.Column<int>(type: "int", nullable: false),
                    MeterDataFileServicePointId = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "varchar(5)", nullable: true),
                    Period = table.Column<int>(type: "int", nullable: false),
                    ImportEnergy = table.Column<decimal>(type: "decimal(7,4)", nullable: false),
                    ExportEnergy = table.Column<decimal>(type: "decimal(7,4)", nullable: false),
                    ReadingFlag = table.Column<decimal>(type: "decimal(7,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterDataFileDataPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterDataFileDataPeriod_MeterDataFileOperatingDate_MeterDataFileOperatingDateId",
                        column: x => x.MeterDataFileOperatingDateId,
                        principalTable: "MeterDataFileOperatingDate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeterDataFileDataPeriod_MeterDataFileOperatingDateId",
                table: "MeterDataFileDataPeriod",
                column: "MeterDataFileOperatingDateId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterDataFileHeader_MeterDataFileId",
                table: "MeterDataFileHeader",
                column: "MeterDataFileId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterDataFileOperatingDate_MeterDataFileHeaderId",
                table: "MeterDataFileOperatingDate",
                column: "MeterDataFileHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterDataFileServicePoint_MeterDataFileHeaderId",
                table: "MeterDataFileServicePoint",
                column: "MeterDataFileHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterDataFileTrailer_MeterDataFileId",
                table: "MeterDataFileTrailer",
                column: "MeterDataFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeterDataFileDataPeriod");

            migrationBuilder.DropTable(
                name: "MeterDataFileServicePoint");

            migrationBuilder.DropTable(
                name: "MeterDataFileTrailer");

            migrationBuilder.DropTable(
                name: "MeterDataFileOperatingDate");

            migrationBuilder.DropTable(
                name: "MeterDataFileHeader");

            migrationBuilder.DropTable(
                name: "MeterDataFile");
        }
    }
}
