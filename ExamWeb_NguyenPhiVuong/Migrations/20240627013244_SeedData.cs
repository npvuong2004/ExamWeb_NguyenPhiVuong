using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_NguyenPhiVuong.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaNhacs",
                columns: new[] { "Id", "GiaBan", "NgheSi", "SoLuong", "TieuDe", "TrongNuoc" },
                values: new object[,]
                {
                    { 1, 105000.0, "Tuấn Vũ", 20, "CD Nỗi buồn gác trọ", true },
                    { 2, 250000.0, "Chế Linh", 15, "CD Bài tình ca đêm", true },
                    { 3, 230000.0, "BABYMONSTER", 10, "CD BABYMONSTER", false },
                    { 4, 150000.0, "Mạnh Quỳnh", 30, "CD Chuyện chúng mình", true },
                    { 5, 27000.0, "Taylor Swift", 10, "CD Today's US-UK Hit ", false },
                    { 6, 220000.0, "Văn Mai Hương", 40, "CD Đoá hồng nhạc việt", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
