using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 703, DateTimeKind.Local).AddTicks(50), "Sports, Tools & Health" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 704, DateTimeKind.Local).AddTicks(2455), "Electronics" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 704, DateTimeKind.Local).AddTicks(2471), "Books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 15, 1, 0, 705, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 15, 1, 0, 705, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 15, 1, 0, 705, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 15, 1, 0, 705, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 719, DateTimeKind.Local).AddTicks(7168), "Sit praesentium hesap incidunt aut." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 719, DateTimeKind.Local).AddTicks(7233), "Sed sıradanlıktan kalemi dışarı ipsum.", "Koşuyorlar qui." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 719, DateTimeKind.Local).AddTicks(7260), "Nostrum masaya explicabo consequatur molestiae.", "Ea." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 722, DateTimeKind.Local).AddTicks(8384), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6.812015011763740m, 178.49m, "Handcrafted Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 722, DateTimeKind.Local).AddTicks(8452), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4.420287612809820m, 715.13m, "Ergonomic Frozen Car" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 51, 49, 158, DateTimeKind.Local).AddTicks(8038), "Books & Industrial" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 51, 49, 160, DateTimeKind.Local).AddTicks(911), "Home" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 51, 49, 160, DateTimeKind.Local).AddTicks(928), "Baby" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 14, 51, 49, 160, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 14, 51, 49, 160, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 14, 51, 49, 160, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 14, 51, 49, 160, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 51, 49, 175, DateTimeKind.Local).AddTicks(5026), "Kapının gidecekmiş mi ve çünkü." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 51, 49, 175, DateTimeKind.Local).AddTicks(5091), "İncidunt ut suscipit ratione amet.", "Otobüs illo." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 51, 49, 175, DateTimeKind.Local).AddTicks(5118), "Gazete qui dignissimos reprehenderit consequatur.", "Kalemi." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 51, 49, 178, DateTimeKind.Local).AddTicks(6014), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0.940536408587860m, 712.87m, "Tasty Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 51, 49, 178, DateTimeKind.Local).AddTicks(6087), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 9.250331674371290m, 564.79m, "Fantastic Frozen Sausages" });
        }
    }
}
