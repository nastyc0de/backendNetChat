using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("eb60446d-45f9-4815-b245-632e1e24a074"), "Canal de .NET CORE", ".NET CORE" },
                    { new Guid("9b243419-e787-41e7-8b49-6d2cdf52c87d"), "Canal de ReactJs", "ReactJs" },
                    { new Guid("08050080-875f-4dfd-9093-e28132b197d3"), "Canal de Angular", "Angular" },
                    { new Guid("fbb486bb-0fe9-4e6b-b5f5-c93ac9acf21d"), "Canal de Vue", "Vue" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "id",
                keyValue: new Guid("08050080-875f-4dfd-9093-e28132b197d3"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "id",
                keyValue: new Guid("9b243419-e787-41e7-8b49-6d2cdf52c87d"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "id",
                keyValue: new Guid("eb60446d-45f9-4815-b245-632e1e24a074"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "id",
                keyValue: new Guid("fbb486bb-0fe9-4e6b-b5f5-c93ac9acf21d"));
        }
    }
}
