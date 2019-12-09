using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBSITEBANMAYTINH.Data.Migrations
{
    public partial class addSanPhamChonChoHoaDon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateTime>(nullable: false),
                    TenKhachHang = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    isConfirmed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamChonChoHoaDon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(nullable: false),
                    SanPhamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamChonChoHoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPhamChonChoHoaDon_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChonChoHoaDon_SANPHAM_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SANPHAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChonChoHoaDon_AppointmentId",
                table: "SanPhamChonChoHoaDon",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChonChoHoaDon_SanPhamId",
                table: "SanPhamChonChoHoaDon",
                column: "SanPhamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPhamChonChoHoaDon");

            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
