using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBSITEBANMAYTINH.Data.Migrations
{
    public partial class addSANPHAMToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "SANPHAM",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ACCOUNT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<bool>(nullable: false),
                    DiemTich = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangId = table.Column<int>(nullable: false),
                    SanPhamId = table.Column<int>(nullable: false),
                    SoLuongSanPham = table.Column<int>(nullable: false),
                    TongDonGia = table.Column<double>(nullable: false),
                    NgayLap = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOADON", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HOADON_KHACHHANG_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KHACHHANG",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HOADON_SANPHAM_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SANPHAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_KhachHangId",
                table: "HOADON",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_SanPhamId",
                table: "HOADON",
                column: "SanPhamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "SANPHAM");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ACCOUNT");
        }
    }
}
