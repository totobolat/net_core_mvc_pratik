using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pratik.Migrations
{
    /// <inheritdoc />
    public partial class Client : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCategory",
                table: "Product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Title = table.Column<string>(type: "varchar(100)", nullable: true),
                    Comment = table.Column<string>(type: "varchar(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductSize = table.Column<int>(type: "integer", nullable: false),
                    BedroomCount = table.Column<int>(type: "integer", nullable: false),
                    BathCount = table.Column<int>(type: "integer", nullable: false),
                    RoomCount = table.Column<int>(type: "integer", nullable: false),
                    GarageSize = table.Column<int>(type: "integer", nullable: false),
                    BuildYear = table.Column<char>(type: "char(4)", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Location = table.Column<string>(type: "varchar(500)", nullable: true),
                    VideoUrl = table.Column<string>(type: "varchar(1000)", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductDetailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ProductCategory",
                table: "Product");
        }
    }
}
