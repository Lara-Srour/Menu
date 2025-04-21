using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Menu.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDishImageUrl2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://png.pngtree.com/png-vector/20240727/ourmid/pngtree-traditional-margherita-pizza-from-campania-png-image_13235087.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fau.ooni.com%2Fblogs%2Frecipes%2Fmargherita-pizza&psig=AOvVaw03plJSeWn3w0RSmRXs9IML&ust=1735641286450000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKiLsOSlz4oDFQAAAAAdAAAAABAZ");
        }
    }
}
