using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace File_Upload.Migrations
{
    /// <inheritdoc />
    public partial class GiftTableWithimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiftImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gifts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Gifts",
                columns: new[] { "Id", "GiftImage" },
                values: new object[,]
                {
                    { 1, "https://media.istockphoto.com/id/1443034333/photo/christmas-or-birthday-gift-box-on-white-wooden-table-against-blue-turquoise-bokeh-lights.jpg?s=612x612&w=0&k=20&c=9EzZqIg271JMqgd5m6JutoPxrsKtQAXzM-r_QyHTkws=" },
                    { 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZoVPSd6j-4ifkP5-Ec63-2GIsB29FMM5g9w&s" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gifts");
        }
    }
}
