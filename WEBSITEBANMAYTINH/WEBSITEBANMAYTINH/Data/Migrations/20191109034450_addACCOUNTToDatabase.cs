using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBSITEBANMAYTINH.Data.Migrations
{
    public partial class addACCOUNTToDatabase : Migration
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
                    PassWord = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCOUNT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LOAISANPHAM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSanPham = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAISANPHAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NHASANXUAT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaSanXuat = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<int>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHASANXUAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    DonGia = table.Column<double>(nullable: false),
                    LoaiSanPhamId = table.Column<int>(nullable: false),
                    NhaSanXuatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANPHAM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SANPHAM_LOAISANPHAM_LoaiSanPhamId",
                        column: x => x.LoaiSanPhamId,
                        principalTable: "LOAISANPHAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SANPHAM_NHASANXUAT_NhaSanXuatId",
                        column: x => x.NhaSanXuatId,
                        principalTable: "NHASANXUAT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_LoaiSanPhamId",
                table: "SANPHAM",
                column: "LoaiSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_NhaSanXuatId",
                table: "SANPHAM",
                column: "NhaSanXuatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCOUNT");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "LOAISANPHAM");

            migrationBuilder.DropTable(
                name: "NHASANXUAT");
        }
    }
}
