using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace marksSite.Migrations
{
    public partial class marks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Analog" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Digital" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 1, "AirMax Based off the original Air Max 90, designer Virgil Abloh, decrostructed the design of the upper portion of the shoe. Seude & synthtic material's make the upper portion. While the OFF-WHITE branding can be seen on the medial sides of the shoe. Last but not least, is the famous tag located on the upper eyelet. This shoe is presented in the colorway of, Desert Ore/Hyper Jade/Bright Mango.", "image.jpg", "Nike Air Max 90's OFF-WHITE edition" },
                    { 2, 1, "Aveline in black. Exquisite, extravagant and the epitome of elegance, this special occasion style hosts oversized bold crinoline bows to offer a 'same but different' look on each pump. The bows are intricately woven, hand tied and sewn on for a dramatic finish ", "Jimmy-white.jpeg", "High Heels Jimmy Choo" },
                    { 3, 2, "Coffee was first brought to the country of Brazil, by a man named Francisco de Melo Palheta, in 1727. He planted the first coffee tree in the state of Para and it thrived and made a easy transition to Rio de Janeiro by 1770. There are two types of beans that are used for production in Brazil. The first bean is called the robusta bean, the second is called the arabica bean. The majority of the coffee grown in Brazil is located in the southern portion of the country. Arabica is known to be the better tasting bean of the two types, and is also the majority in annual production at 80%. Brazil as a country has a annual production rate of 7.9 billion pounds, as of 2018 records. America is the leading country of coffee consumption at 400 million cup's per day. At this rate, coffee is not going anywhere but up, in the United States anytime soon.", "coffee.jpg", "Cold Brew Coffee" },
                    { 4, 2, "It's known as one of the best tasting energy drinks on the market, with a unique flavor unlike any of its competitors. Contains 260 mg of caffeine per can, higher than the caffeine content in a Red Bull, Rockstar, or Monster. Also offered in a variety of a few flavors including citrus, grape, and loaded cherry", "XtremeShock.png", "Shock Energy Drink" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "ProductId" },
                values: new object[,]
                {
                    { 1, "The shoe is the last one of Virgil's Off-White collab for the Air Max 90's and is probably the best design he has to date. They are not true to size and seem to run a half size smaller. The upper's are wonderfully designed, the lower portion in my eye's is where they really shine at. As with all of his Off-White creations as of late, the added print is very reminiscent of Andy Warhol, and I dig it. As far as paying retail for these shoes, they are awesome, but I wouldn't recommend paying resale pricing unless you are okay with wearing shoes that near the thousand dollar mark.", 1 },
                    { 2, "The shoe is as beautiful as it looks on the site. It's does run small so, I would recommend a 1/2 size up. As long as you're used to wearing heels they are good for an all night wear. Perfect for a dramatic night on the town or an elegant night out. Would I recommend this shoe? Absolutely!", 2 },
                    { 3, "Coffee? yes. Iced or Cold brew coffee? Even better. This stuff right here? The best there is, hands down, nothing else wakes me up faster than this.", 3 },
                    { 4, "Feel it within 15 minutes of drinkning it, fantastic for body building and tastes GREAT!!!!", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
