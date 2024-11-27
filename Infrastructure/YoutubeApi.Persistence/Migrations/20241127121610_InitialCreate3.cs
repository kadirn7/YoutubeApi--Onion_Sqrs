using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 16, 9, 770, DateTimeKind.Local).AddTicks(8726), "Games, Toys & Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 16, 9, 772, DateTimeKind.Local).AddTicks(4648), "Health & Beauty" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 16, 9, 772, DateTimeKind.Local).AddTicks(4667), "Tools" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 15, 16, 9, 773, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 15, 16, 9, 773, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 15, 16, 9, 773, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 15, 16, 9, 773, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 16, 9, 788, DateTimeKind.Local).AddTicks(4077), "İçin doloremque salladı quis yazın.", "Quia." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 16, 9, 788, DateTimeKind.Local).AddTicks(4148), "Odit numquam magnam ad corporis.", "Consectetur minima." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 16, 9, 788, DateTimeKind.Local).AddTicks(4263), "Eius voluptas masanın dignissimos sunt.", "Sıradanlıktan." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 16, 9, 791, DateTimeKind.Local).AddTicks(7883), 1.00354361933880m, 870.19m, "Rustic Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 16, 9, 791, DateTimeKind.Local).AddTicks(7952), "The Football Is Good For Training And Recreational Purposes", 6.865242328885380m, 803.46m, "Rustic Rubber Pizza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 719, DateTimeKind.Local).AddTicks(7168), "Sit praesentium hesap incidunt aut.", "Aliquam." });

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
                columns: new[] { "CreatedDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 722, DateTimeKind.Local).AddTicks(8384), 6.812015011763740m, 178.49m, "Handcrafted Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 1, 0, 722, DateTimeKind.Local).AddTicks(8452), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4.420287612809820m, 715.13m, "Ergonomic Frozen Car" });
        }
    }
}
