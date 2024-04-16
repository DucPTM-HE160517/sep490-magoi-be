using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class set_db_timezone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER DATABASE \"FR_Restaurant_DB\" SET TIMEZONE TO 'UTC'");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752772/food/x3cmbnieirpdhnwjksx1.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752931/food/sjdjybr8ywcxymb9zs7u.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752944/food/et1ikezxar76ax8qwbse.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "UnitPrice" },
                values: new object[] { "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712913205/food/rvzq0lp5pst3ndgbiwps.jpg", 880000f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754609/food/lllceyocl5alvttkrek0.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754663/food/uz171brtyh6nndmyi1fa.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "UnitPrice" },
                values: new object[] { "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754649/food/dk5p48irgg1qkfu6hem6.jpg", 960000f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712913257/food/pxlupobcs1zbfnb8pfwc.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754683/food/wyecqhosqih1dp5kqdoi.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754693/food/qwdsvgxlmkb3o5ihd6w5.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754713/food/nikdk72dzagoq5uufpyp.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712755040/food/gzuhr5ftcbmsw56ugllf.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712755090/food/zlcwf0ylh37t08xfqnjq.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "UnitPrice" },
                values: new object[] { "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712913229/food/ihmyc6vfwv9mcrhttncg.jpg", 700000f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712755058/food/louyddpnd8jdxfucc0jk.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752851/food/okhglhvncr0ajufxnhvy.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752833/food/sddppgmwzkphvm1in0pi.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "big-beerfest-bausages.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "garlic-bread.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "french-fried.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "UnitPrice" },
                values: new object[] { "aus-rib-eye-mb4-5.jpg", 1280000f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "aus-rib-eye-mb7-8.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "us-prime-rib-eye.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "UnitPrice" },
                values: new object[] { "aus-black-angus-t-bone.jpg", 1160000f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "us-rib-eye.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "mashed-potato.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "roasted-baby-potato.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "coca-cola.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "tapid-water.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "sinh-to-dua-hau.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "UnitPrice" },
                values: new object[] { "barola.jpg", 1200000f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "ginger-cream-brulee.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "warm-chocolate-lava-cake.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "ice-cream-haagen-dazs.jpg");
        }
    }
}
