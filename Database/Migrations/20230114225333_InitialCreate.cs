using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Needs = table.Column<string>(type: "TEXT", nullable: false),
                    Decadency = table.Column<string>(type: "TEXT", nullable: false),
                    Will = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProducerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_Races_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CreatedAt", "Decadency", "Description", "Name", "Needs", "UpdatedAt", "Will" },
                values: new object[,]
                {
                    { new Guid("01c1bffc-4319-fbcc-d4fe-f4779de652ef"), new DateTime(2022, 8, 19, 8, 50, 56, 309, DateTimeKind.Local).AddTicks(3383), "low", "Soluta voluptate accusantium aut.\nDolor quod eos enim.\nNihil libero aut rem laboriosam voluptatem et.\nQui totam aut quam.\nEst magni velit.\nEa laborum in quos alias.\nError et non unde.\nNostrum nobis aspernatur.\nEius consequatur voluptatem libero voluptas molestiae et.\nEt odio error est.\nIpsam voluptas eos ea enim porro blanditiis quae ut.\nVoluptas illo est facilis fuga reiciendis dolor.", "recusandae", "medium", new DateTime(2022, 8, 2, 8, 14, 8, 421, DateTimeKind.Local).AddTicks(2554), "high" },
                    { new Guid("29e07435-46ac-b482-f660-ad4ee27f7752"), new DateTime(2022, 4, 10, 6, 43, 20, 795, DateTimeKind.Local).AddTicks(7327), "low", "Nostrum iure voluptas animi harum porro deserunt est est quo.\nCulpa sunt eaque aperiam odio omnis ea aperiam sint autem.\nFugiat id quae voluptatem amet molestiae.\nRem saepe assumenda nisi eligendi et magnam quia.\nFuga velit sit et molestiae minus eos.\nNostrum nostrum id ut quos provident perferendis quia.\nLabore porro quasi et in vel possimus et.\nMagni commodi eligendi aut quo.\nVeniam eos recusandae adipisci dolorum quo quisquam iusto exercitationem asperiores.\nExercitationem ut reiciendis ipsam qui.\nDistinctio aut quas sit dolor et repudiandae facilis delectus ex.\nMolestias dolor porro enim eum maxime molestias ut.", "eaque", "low", new DateTime(2022, 4, 6, 22, 10, 18, 652, DateTimeKind.Local).AddTicks(3960), "medium" },
                    { new Guid("41d23e91-cb89-73ec-470c-9cec93734f18"), new DateTime(2022, 5, 16, 19, 55, 50, 975, DateTimeKind.Local).AddTicks(5335), "high", "Repellat ratione id tempora doloribus voluptates.\nCorporis maxime minus occaecati est qui culpa.\nQuas ea delectus numquam.\nExcepturi nihil odio in aut velit quam ut sed.\nVoluptatibus labore eum natus iste quia eaque maiores rerum voluptatum.\nQuaerat amet qui tempora numquam accusantium nihil.\nAccusantium in ab maxime.\nEum non praesentium dolore ea aut.\nLaudantium repudiandae sed autem ab omnis veniam dolorem ut eum.\nVoluptatem nostrum tempore architecto laborum quia hic consequatur blanditiis.\nEt quo libero tempora recusandae quia.\nAd quia praesentium cum accusantium.", "est", "medium", null, "medium" },
                    { new Guid("4b7a8581-d1e1-f89b-33c4-43258eae9b27"), new DateTime(2022, 10, 16, 20, 33, 36, 26, DateTimeKind.Local).AddTicks(1546), "medium", "Sunt est ratione deleniti ut.\nVoluptatum dolores ex nobis at a ut mollitia et aspernatur.\nAccusamus ipsum iusto ea est sint eos eos.\nAut atque rerum eaque suscipit impedit voluptatem accusamus.\nQui expedita assumenda.\nNihil consequatur consequuntur quis laudantium et qui quas culpa officiis.\nEt voluptatem eos ipsam veritatis numquam sapiente ducimus quae necessitatibus.\nSint molestiae autem ipsa soluta sit est voluptas enim.\nNihil beatae culpa possimus sed quos.\nPorro ipsa eius totam veritatis voluptatem.\nAccusantium ut impedit.\nReiciendis fuga sit repellat voluptatum et cumque itaque eum.", "voluptate", "medium", new DateTime(2022, 9, 7, 7, 1, 40, 623, DateTimeKind.Local).AddTicks(6380), "high" },
                    { new Guid("5c4f2be0-46e3-39a5-6301-ba43314b846a"), new DateTime(2022, 12, 4, 12, 45, 6, 155, DateTimeKind.Local).AddTicks(7288), "low", "Qui ut ut pariatur qui qui.\nNihil totam distinctio porro cupiditate iste aperiam sed.\nOdit commodi officiis quia voluptate recusandae officiis.\nCommodi quis enim ex est ratione quo quae est.\nPerferendis dolorum eum rerum eum molestias a.\nIpsum nam blanditiis quos cupiditate tempore delectus harum nobis.\nIllo voluptatem blanditiis architecto fugiat nemo ut.\nVelit est excepturi reprehenderit qui qui.\nCum excepturi autem aperiam dolor debitis nobis.\nVero nisi veritatis neque facere ab similique totam placeat.\nNeque ipsum aut vel qui autem et.\nNeque et quos voluptatem quaerat officia animi enim impedit dolorum.", "repellendus", "medium", new DateTime(2022, 11, 30, 16, 51, 47, 222, DateTimeKind.Local).AddTicks(7225), "low" },
                    { new Guid("850ffcbf-2712-86cf-e0aa-ae77777080d2"), new DateTime(2022, 1, 29, 14, 36, 19, 855, DateTimeKind.Local).AddTicks(2762), "low", "Nobis velit error doloribus quam.\nAlias ipsa libero omnis sed sunt sit hic nemo.\nCumque exercitationem itaque cupiditate.\nIncidunt quia sunt provident numquam inventore quia molestias quia.\nOmnis debitis libero occaecati error et at adipisci.\nQuis molestias nihil atque.\nIllum autem numquam magnam odio dolorum.\nSaepe ut dicta est ut sequi dolores eos vel odio.\nDelectus molestias vel cumque qui.\nNihil velit omnis.\nLaudantium voluptatem ex nisi explicabo.\nDolores vel ut voluptatem maiores voluptas reprehenderit velit excepturi.", "nam", "low", new DateTime(2022, 5, 8, 13, 46, 49, 398, DateTimeKind.Local).AddTicks(5221), "medium" },
                    { new Guid("b2b02a90-9543-68c9-5c38-af4575c8e27e"), new DateTime(2022, 1, 24, 10, 32, 32, 0, DateTimeKind.Local).AddTicks(2172), "medium", "Doloribus id at.\nEum quisquam rem iure.\nInventore quia repellat atque nulla animi alias.\nRem numquam qui eius et.\nEveniet incidunt aliquid in doloribus eos et voluptatem.\nFacere animi molestias exercitationem sapiente.\nEt dolor voluptas enim quis sequi est nihil aliquam quibusdam.\nQuo nam dolorem quas voluptas provident doloribus recusandae corporis.\nPerspiciatis id totam odio sit animi esse incidunt.\nVelit possimus aperiam.\nLaboriosam minus dicta neque.\nQuibusdam ab sed cum voluptatibus facilis.", "odio", "medium", null, "high" },
                    { new Guid("de403f6d-f150-72dc-bdfb-af963a55d676"), new DateTime(2022, 3, 30, 21, 14, 9, 47, DateTimeKind.Local).AddTicks(3151), "high", "Consequatur vel cupiditate laborum et hic ea molestiae.\nCorporis fuga itaque et est cupiditate est vitae voluptate odit.\nQuasi harum commodi numquam et.\nRerum adipisci sed doloribus fugiat.\nEa non ducimus ut omnis enim.\nEsse officiis earum quis nesciunt accusamus totam dicta et.\nQuis ut libero officiis iure animi.\nQuibusdam impedit minima.\nEius rem aut enim ullam est qui itaque.\nVoluptatum sed veritatis enim aspernatur repellat velit consequatur.\nMagnam quaerat aspernatur qui cum omnis nobis optio aut facilis.\nAutem dolorum accusantium odit tenetur voluptatem omnis.", "odit", "high", new DateTime(2022, 11, 9, 9, 31, 14, 560, DateTimeKind.Local).AddTicks(1287), "medium" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goods_ProducerId",
                table: "Goods",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
