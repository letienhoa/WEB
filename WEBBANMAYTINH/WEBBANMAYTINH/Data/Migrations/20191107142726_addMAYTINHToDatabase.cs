using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBBANMAYTINH.Data.Migrations
{
    public partial class addMAYTINHToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACCOUNT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    PassWord = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCOUNT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LOAIMAYTINH",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiMay = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAIMAYTINH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NHASANXUAT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaSanXuat = table.Column<string>(nullable: false),
                    NoiSanXuat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHASANXUAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MAYTINH",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMayTinh = table.Column<string>(nullable: false),
                    NgaySanXuat = table.Column<DateTime>(nullable: false),
                    NhaSanXuatId = table.Column<int>(nullable: true),
                    LoaiMayTinhId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAYTINH", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MAYTINH_LOAIMAYTINH_LoaiMayTinhId",
                        column: x => x.LoaiMayTinhId,
                        principalTable: "LOAIMAYTINH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MAYTINH_NHASANXUAT_NhaSanXuatId",
                        column: x => x.NhaSanXuatId,
                        principalTable: "NHASANXUAT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MAYTINH_LoaiMayTinhId",
                table: "MAYTINH",
                column: "LoaiMayTinhId");

            migrationBuilder.CreateIndex(
                name: "IX_MAYTINH_NhaSanXuatId",
                table: "MAYTINH",
                column: "NhaSanXuatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCOUNT");

            migrationBuilder.DropTable(
                name: "MAYTINH");

            migrationBuilder.DropTable(
                name: "LOAIMAYTINH");

            migrationBuilder.DropTable(
                name: "NHASANXUAT");
        }
    }
}
