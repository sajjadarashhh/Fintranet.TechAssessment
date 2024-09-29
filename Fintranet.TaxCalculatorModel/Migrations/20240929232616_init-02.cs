using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fintranet.TaxCalculatorModel.Migrations
{
    /// <inheritdoc />
    public partial class init02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TaxRate",
                table: "TaxRules",
                type: "decimal(18,2)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { new Guid("00e582ed-aeb2-4965-a2eb-db80e373ffbb"), new DateOnly(2013, 12, 23) },
                    { new Guid("1117864a-4fd7-4bf4-bf98-8e390bee9e32"), new DateOnly(2013, 12, 25) },
                    { new Guid("178b1675-07ff-4f20-b7cd-fa8c790c1f1a"), new DateOnly(2013, 12, 30) },
                    { new Guid("208a5256-0401-42f3-a026-464616e4dbd1"), new DateOnly(2013, 6, 4) },
                    { new Guid("3020ac55-2cf2-408f-a5cf-b5e86ef073a3"), new DateOnly(2013, 6, 20) },
                    { new Guid("341ac46b-275e-4c2f-a1f9-b5c4da1b9e0a"), new DateOnly(2013, 3, 31) },
                    { new Guid("37e0778d-0385-4478-8460-903b9d1db02a"), new DateOnly(2013, 4, 29) },
                    { new Guid("37e79e9a-7404-4fb9-a42a-599b726ff139"), new DateOnly(2013, 1, 1) },
                    { new Guid("429bbc30-6889-4d6a-b8b7-7faf22c52fb0"), new DateOnly(2013, 12, 31) },
                    { new Guid("68168060-beef-4635-a562-502cd9072f36"), new DateOnly(2013, 12, 24) },
                    { new Guid("694386f6-3a08-4987-9018-23d9725321e4"), new DateOnly(2013, 10, 31) },
                    { new Guid("70d58d17-6afc-4e55-a54e-501ace52e639"), new DateOnly(2013, 12, 26) },
                    { new Guid("7a171093-e7ed-47c0-96fa-8aaaff74f84b"), new DateOnly(2013, 11, 1) },
                    { new Guid("80502033-6dff-412e-b357-f2e1f90057f3"), new DateOnly(2013, 3, 29) },
                    { new Guid("86bcf586-369d-4d69-8ecb-4804f56a9210"), new DateOnly(2013, 6, 21) },
                    { new Guid("88d7faeb-0739-4989-8427-d93feaa3f45f"), new DateOnly(2013, 4, 1) },
                    { new Guid("8f9ff5d0-5776-4f96-bbb9-c7c439f5127e"), new DateOnly(2013, 6, 5) },
                    { new Guid("9f64a460-c4b0-41fa-aa63-f506050fa6b2"), new DateOnly(2013, 4, 30) },
                    { new Guid("a972d205-934f-4724-beac-5f429823faba"), new DateOnly(2013, 5, 8) },
                    { new Guid("badfc61c-f96f-4517-88cf-f0b837ee9104"), new DateOnly(2013, 5, 1) },
                    { new Guid("c4e60737-27f0-4372-a8a2-4f83963133d9"), new DateOnly(2013, 3, 28) },
                    { new Guid("c718b24d-0b90-4bf2-a9f0-5b00f67293b1"), new DateOnly(2013, 6, 6) },
                    { new Guid("e7debbe6-5bf1-47ce-9c0b-9aa36673c140"), new DateOnly(2013, 5, 9) },
                    { new Guid("fcafbfe3-d04d-4f21-8d8d-2a22fc8f37eb"), new DateOnly(2013, 3, 27) },
                    { new Guid("ff389abc-6c27-4b34-afc4-064bf91050e2"), new DateOnly(2013, 5, 7) }
                });

            migrationBuilder.InsertData(
                table: "TaxRules",
                columns: new[] { "Id", "EndTime", "StartTime", "TaxRate" },
                values: new object[,]
                {
                    { new Guid("1633e63b-bf44-47f0-915e-874e673cc8b3"), new TimeSpan(0, 16, 59, 0, 0), new TimeSpan(0, 15, 30, 0, 0), 18m },
                    { new Guid("4364d071-5da8-4e3b-8cba-d286118ee169"), new TimeSpan(0, 8, 29, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 13m },
                    { new Guid("63c2790f-eda8-4afe-b508-8dca308b84ae"), new TimeSpan(0, 17, 59, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 13m },
                    { new Guid("95ab77a7-8004-4f62-9c47-51f731895792"), new TimeSpan(0, 6, 59, 0, 0), new TimeSpan(0, 6, 30, 0, 0), 13m },
                    { new Guid("9be2b156-c8b5-4838-b7ac-850ab17812df"), new TimeSpan(0, 6, 29, 0, 0), new TimeSpan(0, 6, 0, 0, 0), 8m },
                    { new Guid("c1f50043-eedb-4f3b-8de5-0cbcdd4e50fa"), new TimeSpan(0, 15, 29, 0, 0), new TimeSpan(0, 15, 0, 0, 0), 13m },
                    { new Guid("d902487d-4087-4ce9-ac4a-ba09249a4e11"), new TimeSpan(0, 14, 59, 0, 0), new TimeSpan(0, 8, 30, 0, 0), 8m },
                    { new Guid("de212078-fe87-4cf6-b8c0-d969487c1507"), new TimeSpan(0, 7, 59, 0, 0), new TimeSpan(0, 7, 0, 0, 0), 18m },
                    { new Guid("fd030839-e905-4c95-ada6-afadb6ad0c76"), new TimeSpan(0, 18, 29, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 8m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("00e582ed-aeb2-4965-a2eb-db80e373ffbb"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("1117864a-4fd7-4bf4-bf98-8e390bee9e32"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("178b1675-07ff-4f20-b7cd-fa8c790c1f1a"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("208a5256-0401-42f3-a026-464616e4dbd1"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("3020ac55-2cf2-408f-a5cf-b5e86ef073a3"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("341ac46b-275e-4c2f-a1f9-b5c4da1b9e0a"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("37e0778d-0385-4478-8460-903b9d1db02a"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("37e79e9a-7404-4fb9-a42a-599b726ff139"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("429bbc30-6889-4d6a-b8b7-7faf22c52fb0"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("68168060-beef-4635-a562-502cd9072f36"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("694386f6-3a08-4987-9018-23d9725321e4"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("70d58d17-6afc-4e55-a54e-501ace52e639"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("7a171093-e7ed-47c0-96fa-8aaaff74f84b"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("80502033-6dff-412e-b357-f2e1f90057f3"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("86bcf586-369d-4d69-8ecb-4804f56a9210"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("88d7faeb-0739-4989-8427-d93feaa3f45f"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("8f9ff5d0-5776-4f96-bbb9-c7c439f5127e"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("9f64a460-c4b0-41fa-aa63-f506050fa6b2"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("a972d205-934f-4724-beac-5f429823faba"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("badfc61c-f96f-4517-88cf-f0b837ee9104"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("c4e60737-27f0-4372-a8a2-4f83963133d9"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("c718b24d-0b90-4bf2-a9f0-5b00f67293b1"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("e7debbe6-5bf1-47ce-9c0b-9aa36673c140"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("fcafbfe3-d04d-4f21-8d8d-2a22fc8f37eb"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("ff389abc-6c27-4b34-afc4-064bf91050e2"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("1633e63b-bf44-47f0-915e-874e673cc8b3"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("4364d071-5da8-4e3b-8cba-d286118ee169"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("63c2790f-eda8-4afe-b508-8dca308b84ae"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("95ab77a7-8004-4f62-9c47-51f731895792"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("9be2b156-c8b5-4838-b7ac-850ab17812df"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("c1f50043-eedb-4f3b-8de5-0cbcdd4e50fa"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("d902487d-4087-4ce9-ac4a-ba09249a4e11"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("de212078-fe87-4cf6-b8c0-d969487c1507"));

            migrationBuilder.DeleteData(
                table: "TaxRules",
                keyColumn: "Id",
                keyValue: new Guid("fd030839-e905-4c95-ada6-afadb6ad0c76"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxRate",
                table: "TaxRules",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)",
                oldPrecision: 3);
        }
    }
}
