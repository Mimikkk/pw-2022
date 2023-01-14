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
                });

            migrationBuilder.CreateTable(
                name: "RaceEntity",
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
                    table.PrimaryKey("PK_RaceEntity", x => x.Id);
                });

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
                name: "GoodEntity",
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
                    table.PrimaryKey("PK_GoodEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodEntity_RaceEntity_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "RaceEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RaceEntity",
                columns: new[] { "Id", "CreatedAt", "Decadency", "Description", "Name", "Needs", "UpdatedAt", "Will" },
                values: new object[,]
                {
                    { new Guid("034e6b64-897e-45b2-9aae-99b3667f2459"), new DateTime(2022, 7, 16, 7, 42, 14, 486, DateTimeKind.Local).AddTicks(6170), "high", "Quis ut qui at maiores optio aut eum.\nQuae sed iure et et sunt est.\nVoluptatem distinctio eum id.\nDoloremque ea id suscipit.\nPraesentium id dolore.\nQui molestias culpa iure voluptas.\nEarum et aut sunt suscipit laborum similique molestiae deleniti perspiciatis.\nVelit saepe voluptatem et voluptatum iure nisi quidem nemo ut.\nQui illo fugit quo occaecati consequatur autem cum aut illo.\nMagnam asperiores ut.\nQuia repellat mollitia aut sunt.\nRem ut ea.", "molestiae", "medium", new DateTime(2022, 10, 23, 6, 15, 42, 908, DateTimeKind.Local).AddTicks(7866), "high" },
                    { new Guid("0e7f5f6e-78f1-a9a6-e671-31eb2bb50f61"), new DateTime(2022, 5, 16, 15, 50, 40, 834, DateTimeKind.Local).AddTicks(5789), "low", "Velit sunt perspiciatis eum ad.\nVitae ea qui magnam nemo distinctio aut dolores error.\nIllum quia enim sit id tenetur laudantium aut cumque consequatur.\nDolorum et sunt omnis.\nNam voluptatem accusamus pariatur quia molestiae modi mollitia a.\nBeatae inventore nemo est autem necessitatibus ut cumque.\nFacilis mollitia ipsam voluptate dignissimos.\nSit autem ea et repudiandae tempore culpa incidunt aperiam.\nOfficia cumque soluta consequatur consectetur impedit.\nVoluptates facilis mollitia rerum non eos.\nEt tempora in assumenda qui deserunt non nulla.\nSapiente sapiente a iure praesentium rerum.", "esse", "low", new DateTime(2022, 10, 14, 23, 53, 32, 260, DateTimeKind.Local).AddTicks(608), "medium" },
                    { new Guid("124c596c-6f5f-9af8-bec6-f9e99b5192b5"), new DateTime(2022, 3, 7, 7, 41, 36, 705, DateTimeKind.Local).AddTicks(8166), "medium", "Impedit libero necessitatibus architecto atque.\nNam et aut.\nQuia suscipit quas optio inventore dolores qui.\nFuga deleniti accusantium fugiat ex quia distinctio aut quo.\nQui ut laborum.\nUllam sapiente est quibusdam quis suscipit enim quisquam cum.\nVoluptatum cumque enim et ut aliquid sequi quae rerum.\nRepudiandae numquam dolores non labore molestiae perferendis voluptas.\nIpsa veniam voluptatem eum repellat sed eaque et sit.\nNemo ex voluptates quia esse.\nEst in nemo adipisci sapiente iure natus placeat sit.\nQui itaque sit sit sapiente exercitationem sit pariatur adipisci.", "minima", "low", null, "high" },
                    { new Guid("2a8fbfc6-f292-fb81-2bf7-cc51c3ec86b0"), new DateTime(2022, 7, 18, 19, 42, 57, 401, DateTimeKind.Local).AddTicks(4917), "high", "Ut illum quia tenetur minus maiores.\nDelectus laboriosam est expedita.\nSuscipit autem ducimus qui quis nihil.\nSoluta sit esse eum et velit.\nVeniam aspernatur beatae.\nSunt nemo modi sunt atque et et.\nAutem quam et assumenda.\nA ut fugit delectus ut deserunt provident.\nSapiente vero enim qui.\nEsse suscipit necessitatibus et nemo molestias aut vel veritatis.\nIn corrupti debitis doloribus sunt dolorem aut ut odio ut.\nSapiente ut quia.", "quo", "high", new DateTime(2022, 2, 18, 7, 31, 43, 907, DateTimeKind.Local).AddTicks(8831), "medium" },
                    { new Guid("36c2004a-b45c-f35d-1633-4781fb5a1e19"), new DateTime(2022, 3, 27, 1, 31, 16, 44, DateTimeKind.Local).AddTicks(4025), "high", "Tempora voluptates soluta aut nobis quia doloribus quo ipsum.\nAmet omnis voluptate temporibus est saepe.\nProvident sapiente voluptatem rerum consectetur error.\nDolores a quia excepturi repellendus odit.\nNisi a aut et quia nesciunt sed.\nNon voluptatem qui rerum error tenetur assumenda aut.\nId expedita nihil.\nDolore alias cum iure adipisci.\nDolor magni cumque harum corrupti consequatur aliquam asperiores.\nQuia hic qui excepturi quidem.\nAut quos ad quis.\nEst laudantium commodi.", "quas", "medium", null, "low" },
                    { new Guid("5be1f358-b704-027a-e237-fdb1947113b6"), new DateTime(2022, 9, 2, 6, 9, 37, 101, DateTimeKind.Local).AddTicks(2703), "low", "Est sequi accusantium delectus.\nMagnam quo eos voluptatem quia quo.\nNisi ut saepe provident sed nihil.\nDoloremque explicabo corrupti amet qui rem accusamus.\nEt voluptatibus asperiores sit adipisci corrupti non veritatis est.\nDebitis consequatur ipsam velit sequi.\nAutem aliquam sit id consequatur eaque provident.\nIpsa dolores enim iure nam id blanditiis ut sit.\nConsequatur tenetur ullam commodi.\nIn quibusdam nesciunt et nesciunt velit.\nOccaecati ducimus consectetur repudiandae consequatur iusto sint molestiae.\nVelit et illum cum aut veritatis recusandae qui nemo.", "cumque", "high", new DateTime(2023, 1, 14, 21, 21, 55, 736, DateTimeKind.Local).AddTicks(8560), "high" },
                    { new Guid("af1c809d-407a-7b3c-0381-6196bbbf3212"), new DateTime(2022, 4, 24, 15, 45, 27, 903, DateTimeKind.Local).AddTicks(4354), "medium", "Est sed voluptatem voluptatem dolore.\nQui temporibus aliquid qui natus esse commodi veritatis.\nVoluptatibus amet inventore.\nVoluptas explicabo maiores aut vel.\nOptio sit pariatur possimus aspernatur architecto nulla.\nQuia id sequi et est sunt saepe eveniet.\nTemporibus hic ea.\nDicta ea velit possimus rerum quaerat dolore reprehenderit mollitia doloribus.\nIn eaque ut.\nVoluptas expedita accusantium.\nUt voluptatibus maxime illo voluptate qui molestias voluptatem et.\nFacilis tempora autem.", "quae", "low", null, "low" },
                    { new Guid("bb6f61cb-f8c8-375a-72f6-a9ca795427e0"), new DateTime(2022, 2, 28, 2, 18, 50, 811, DateTimeKind.Local).AddTicks(9763), "high", "Mollitia dicta rerum.\nAut consequatur repellendus excepturi commodi reprehenderit.\nSed quis a voluptatem dolore vitae fuga qui repellendus fuga.\nBlanditiis optio dolor unde.\nRem quos rerum voluptas laudantium praesentium ab et animi culpa.\nMinus sint rerum.\nDolor deserunt suscipit id excepturi quia fugiat esse.\nAut minus excepturi.\nNobis dolorem enim.\nFuga libero sint.\nAsperiores numquam vitae iste sunt ea neque aperiam voluptatem.\nVeritatis unde quisquam facere cupiditate minus.", "commodi", "high", new DateTime(2022, 12, 24, 18, 21, 10, 854, DateTimeKind.Local).AddTicks(3301), "medium" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoodEntity_ProducerId",
                table: "GoodEntity",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodEntity");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "RaceEntity");
        }
    }
}
