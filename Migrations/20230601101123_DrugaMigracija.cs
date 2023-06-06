using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuadoviWebAplikacija.Migrations
{
    public partial class DrugaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quadovi");

            migrationBuilder.CreateTable(
                name: "Bicikl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GodinaProizvodnje = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    SlikaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategorijaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bicikl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bicikl_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bicikl",
                columns: new[] { "Id", "Cijena", "GodinaProizvodnje", "KategorijaId", "Naziv", "SlikaUrl" },
                values: new object[,]
                {
                    { 1, 320m, 2019, 1, "BRDSKI BICIKL ST 120 27,5 ZA TOURING", "https://contents.mediadecathlon.com/p1995217/k$b4ef0580aa6bfc79383a35225fe4f3ff/brdski-bicikl-st-120-275quote-crno-plavi.jpg?format=auto&quality=40&f=800x800" },
                    { 2, 519m, 2021, 2, "CESTOVNI BICIKL RC120 DISC", "https://contents.mediadecathlon.com/p2021839/k$9ef77d1c20368b5fd1bd0e44805b47a6/cestovni-bicikl-rc120-disc-tamnoplavo-narancasti.jpg?format=auto&quality=40&f=800x800" },
                    { 3, 679m, 2023, 3, "Genesis SPEED CROSS SX 4.1 W", "https://www.intersport.hr/media/catalog/product/cache/382907d7f48ae2519bf16cd5f39b77f9/1/9/190550315_00_1.jpg" },
                    { 4, 379m, 2023, 4, "HIBRIDNI BICIKL RIVERSIDE 500", "https://contents.mediadecathlon.com/p1990168/k$d69656b3c8efb170d8a772bb2f3f3481/hibridni-bicikl-riverside-500-plavi.jpg?format=auto&quality=40&f=800x800" },
                    { 5, 588m, 2023, 5, " FUJI Nevada 29 1.7", "https://www.rog-joma.hr/fajlovi/artikli_slike/1610038342.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bicikl_KategorijaId",
                table: "Bicikl",
                column: "KategorijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bicikl");

            migrationBuilder.CreateTable(
                name: "Quadovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    KategorijaId = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    GodinaProizvodnje = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlikaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quadovi_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Quadovi",
                columns: new[] { "Id", "Cijena", "GodinaProizvodnje", "KategorijaId", "Naziv", "SlikaUrl" },
                values: new object[,]
                {
                    { 1, 320m, 2019, 1, "BRDSKI BICIKL ST 120 27,5 ZA TOURING", "https://contents.mediadecathlon.com/p1995217/k$b4ef0580aa6bfc79383a35225fe4f3ff/brdski-bicikl-st-120-275quote-crno-plavi.jpg?format=auto&quality=40&f=800x800" },
                    { 2, 519m, 2021, 2, "CESTOVNI BICIKL RC120 DISC", "https://contents.mediadecathlon.com/p2021839/k$9ef77d1c20368b5fd1bd0e44805b47a6/cestovni-bicikl-rc120-disc-tamnoplavo-narancasti.jpg?format=auto&quality=40&f=800x800" },
                    { 3, 679m, 2023, 3, "Genesis SPEED CROSS SX 4.1 W", "https://www.intersport.hr/media/catalog/product/cache/382907d7f48ae2519bf16cd5f39b77f9/1/9/190550315_00_1.jpg" },
                    { 4, 379m, 2023, 4, "HIBRIDNI BICIKL RIVERSIDE 500", "https://contents.mediadecathlon.com/p1990168/k$d69656b3c8efb170d8a772bb2f3f3481/hibridni-bicikl-riverside-500-plavi.jpg?format=auto&quality=40&f=800x800" },
                    { 5, 588m, 2023, 5, " FUJI Nevada 29 1.7", "https://www.rog-joma.hr/fajlovi/artikli_slike/1610038342.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quadovi_KategorijaId",
                table: "Quadovi",
                column: "KategorijaId");
        }
    }
}
