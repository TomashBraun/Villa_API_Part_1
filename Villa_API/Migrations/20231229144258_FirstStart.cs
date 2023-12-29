using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Villa_API.Migrations
{
    /// <inheritdoc />
    public partial class FirstStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Автор курса сука один раз", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 12, 29, 16, 42, 58, 640, DateTimeKind.Local).AddTicks(9848), "Похоже, что у вас возникает проблема с SSL-сертификатом при подключении к серверу базы данных. В вашей строке подключения к базе данных отсутствует указание на использование SSL. Попробуйте добавить параметр Encrypt=True в вашу строку подключения:", "https://blogger.googleusercontent.com/img/a/AVvXsEgWg40kddLWOx6d70K50ruMx4IThciIis-cnuD2vCATJTgdSDx4pgDaqGC1bHK_j_cDnwfxHPqFztcwBZRPn2Qm59JPzlMLaOxDFYGRflLjdBUGCG0vgvU9Amgpdz9FGR_FNSGPoq-2BuP3jnjzGhvraEUpIDe2mzQ6rpBai-MOyXA9_4U-lymxoQpFWbo", "Royal Villa", 5, "200", 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2023, 12, 29, 16, 42, 58, 640, DateTimeKind.Local).AddTicks(9891), "Эксклюзивная резиденция отеля Conrad Maldives Rangali Island действительно не имеет аналогов. Уникальная двухуровневая вилла располагает главной спальней и ванной комнатой, которые погружены под воду на 5 метров. Это самый настоящий ультрасовременный архитектурный шедевр с “эффектом аквариума”.", "https://blogger.googleusercontent.com/img/a/AVvXsEiIqgEFScWGxzPoWk3ndFOFBBqpQV2Z9W9Lfmh2G-esLTkWN5OeqOb3Zk98YdAxRctNeoqVahg9QbJoDtNbu5RAgDAsiPmS3R1vn76C2HjE289RYdGnLLDz_NUg6sS_YTQzjiGrFU8uGzNUr0jsdFT0hbSeZoBZ6rXo2ik0H85hMhcvdS_GqqFf5ZRLEP0", "Villa 2", 2, "222", 220, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2023, 12, 29, 16, 42, 58, 640, DateTimeKind.Local).AddTicks(9894), "Похоже, что у вас возникает проблема с SSL-сертификатом при подключении к серверу базы данных. В вашей строке подключения к базе данных отсутствует указание на использование SSL. Попробуйте добавить параметр Encrypt=True в вашу строку подключения:", "https://blogger.googleusercontent.com/img/a/AVvXsEg-t9s_PRAwhCzKgMgjd3YFZvGR2HDY2fhCBjg38QEODZKeM0bwRjsIk5V_4t2XLi3xv_8UoeW70fCT0vaCdhG_R9HdonV7rM5Yo8DxUfH8j6YAQLcRELCut9S0dw7y5UgsEuzUgux3ESXMUHrWRehMBkMJfjfuomRpVLU48p9NkhuG_mwzJkPAGNhsAao", "Villa 3", 3, "333", 330, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(2023, 12, 29, 16, 42, 58, 640, DateTimeKind.Local).AddTicks(9896), "Похоже, что у вас возникает проблема с SSL-сертификатом при подключении к серверу базы данных. В вашей строке подключения к базе данных отсутствует указание на использование SSL. Попробуйте добавить параметр Encrypt=True в вашу строку подключения:", "https://blogger.googleusercontent.com/img/a/AVvXsEjT0Iy17tbcAj28-NXMvfBcXIEBZdEXTxm6pu2BBIP7az6g7t7bhnEUMTj3El3l2SEWcilwOA0XV7nUZgsRTCo64Jrc3Aa6HTF9Bs4LdKzqTR6w869x2cLE1NHu7K5Rv0iJEW4bof0RIHTjeJIL1zBK-rLaO4tqhWEy4jltigNGluMeK8noxqeNEAxJ0Ts", "Villa 4", 4, "444", 440, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2023, 12, 29, 16, 42, 58, 640, DateTimeKind.Local).AddTicks(9899), "Похоже, что у вас возникает проблема с SSL-сертификатом при подключении к серверу базы данных. В вашей строке подключения к базе данных отсутствует указание на использование SSL. Попробуйте добавить параметр Encrypt=True в вашу строку подключения:", "https://blogger.googleusercontent.com/img/a/AVvXsEgWZ8JURuTTdEGEvwJcKvRehAjLUqIz1gL5Epy9vOwwTv_vN1xqDB-hqebdZt7ZdInbjlaPvJlaasYisD_3xdvCdXqIAXDwohMaBlRRY6tWjIb29ftD_Lbolr7wiJy4rsdPOquwJJOvVT6sytoS6GJS8skSWoaq3IgEzZzckt14vM8jSrtfNVkAfJ_9BvU", "Villa 5", 5, "555", 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
