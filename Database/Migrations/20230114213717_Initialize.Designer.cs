﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230114213717_Initialize")]
    partial class Initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Models.Goods.GoodEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProducerId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("Models.Races.RaceEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Decadency")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Needs")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Will")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Races");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f73939fe-2bbb-b950-9f35-c554e908dfef"),
                            CreatedAt = new DateTime(2022, 7, 7, 4, 24, 40, 942, DateTimeKind.Local).AddTicks(6051),
                            Decadency = "high",
                            Description = "Nihil dolorem possimus.\nSit quasi et aut.\nIusto eum voluptas qui eligendi.\nNon laudantium est neque quaerat enim velit.\nNihil ea dolorem.\nSunt officia modi non.\nVelit enim voluptas accusantium porro cum ut et velit iste.\nEum exercitationem quo voluptatem repudiandae voluptas consequuntur voluptas.\nRerum dolorem voluptas quisquam quia ipsam sint corporis enim.\nIn nihil eum fugiat ut et illo facilis.\nIpsum aut totam eveniet aut.\nIure blanditiis quidem a ullam delectus error alias fuga molestiae.",
                            Name = "iusto",
                            Needs = "high",
                            UpdatedAt = new DateTime(2022, 12, 5, 5, 37, 37, 889, DateTimeKind.Local).AddTicks(4016),
                            Will = "high"
                        },
                        new
                        {
                            Id = new Guid("b9d4d9fd-8368-dd4e-e1a2-855468528d37"),
                            CreatedAt = new DateTime(2022, 10, 3, 0, 50, 8, 630, DateTimeKind.Local).AddTicks(5599),
                            Decadency = "medium",
                            Description = "Vel ut at sit autem quo.\nUt sit suscipit odio tenetur.\nDoloremque nihil sed sequi omnis vitae.\nCum magnam eum fugit.\nVelit adipisci maiores quis placeat qui non in quos.\nEnim accusantium at labore.\nConsequatur repudiandae rerum quia magni.\nRatione non tenetur earum.\nNam suscipit porro numquam harum alias.\nError suscipit porro nihil ducimus ad esse minima magnam dolor.\nSit eos qui dolorum nam.\nAut eum quae odio vero nesciunt at incidunt et.",
                            Name = "enim",
                            Needs = "high",
                            Will = "low"
                        },
                        new
                        {
                            Id = new Guid("1be494ad-737e-e295-1cf4-d2f1f591d201"),
                            CreatedAt = new DateTime(2022, 8, 23, 19, 43, 22, 20, DateTimeKind.Local).AddTicks(4878),
                            Decadency = "high",
                            Description = "Rem est sunt nam quis.\nEius porro ea temporibus reprehenderit.\nLibero nihil doloribus fugit voluptatem necessitatibus iste autem minima.\nPerspiciatis rerum tenetur quis voluptatibus.\nSaepe a inventore eaque sint expedita omnis velit.\nVeniam excepturi repudiandae.\nEt laborum facere.\nSunt id dolor sequi ipsam ut est dolores.\nAutem velit numquam vero est eum exercitationem harum nihil labore.\nQuisquam ut laborum perspiciatis dicta quis.\nSunt eius repellendus aut et tempora temporibus voluptas incidunt ratione.\nQuod sint optio et in.",
                            Name = "voluptatem",
                            Needs = "medium",
                            Will = "high"
                        },
                        new
                        {
                            Id = new Guid("83beb18e-f972-6a95-de29-57a3a24243cc"),
                            CreatedAt = new DateTime(2023, 1, 3, 5, 40, 51, 830, DateTimeKind.Local).AddTicks(2781),
                            Decadency = "high",
                            Description = "Iure et adipisci repellendus natus nesciunt reiciendis earum voluptatum.\nOfficiis aliquid natus.\nBlanditiis eaque illo aut soluta.\nDebitis quis tempore explicabo sequi reiciendis delectus sunt.\nEt non laboriosam labore.\nNam optio hic at nemo non sit omnis dolore.\nCorrupti voluptatibus distinctio quis ea.\nQuasi voluptate dignissimos est doloremque vel.\nEt quae possimus eum ut.\nAutem maiores veniam error voluptatem sed ipsa voluptate enim.\nLaborum rerum et sed vero explicabo in et ipsum numquam.\nAlias natus molestiae saepe quidem recusandae distinctio eveniet corporis.",
                            Name = "modi",
                            Needs = "low",
                            UpdatedAt = new DateTime(2022, 4, 27, 10, 47, 58, 540, DateTimeKind.Local).AddTicks(7841),
                            Will = "medium"
                        },
                        new
                        {
                            Id = new Guid("ffa5bcae-8f13-3431-a0c4-374de0100b5f"),
                            CreatedAt = new DateTime(2022, 9, 23, 18, 41, 33, 413, DateTimeKind.Local).AddTicks(9985),
                            Decadency = "low",
                            Description = "Sed nemo minus deserunt impedit in et et natus delectus.\nIpsum eos et esse non excepturi nemo modi laboriosam qui.\nSaepe vel fugit.\nEnim possimus aliquam ex quae ex sit.\nFugit iure ullam libero placeat quia.\nMinus quisquam totam occaecati.\nVeniam quia consectetur cupiditate voluptas cumque.\nUt eveniet corrupti possimus et nihil quae.\nNon soluta sed in voluptatum eum modi qui ipsam cupiditate.\nNumquam a repellendus doloribus molestiae.\nAmet aut reiciendis minima.\nEligendi eum dolores voluptatem et velit numquam consequatur ipsum.",
                            Name = "sunt",
                            Needs = "medium",
                            UpdatedAt = new DateTime(2022, 8, 14, 0, 33, 43, 230, DateTimeKind.Local).AddTicks(5377),
                            Will = "medium"
                        },
                        new
                        {
                            Id = new Guid("9d2fcad9-7bc9-ce89-0888-37a23a465e5e"),
                            CreatedAt = new DateTime(2022, 9, 16, 13, 11, 2, 189, DateTimeKind.Local).AddTicks(7906),
                            Decadency = "medium",
                            Description = "Corporis consequuntur quia modi vel.\nNihil hic facilis perferendis cumque est fuga est nemo.\nSed omnis provident sed non qui officia.\nEst vel aliquid.\nRatione in tempora sit asperiores occaecati blanditiis.\nError blanditiis natus qui nesciunt earum dicta delectus nihil.\nQuis a quis repudiandae non.\nEst maiores laborum illo explicabo.\nSit quasi in deserunt beatae consequatur aspernatur dicta.\nRerum occaecati quo.\nDolores dolorem ut id ratione dolorem consequatur consequatur esse tempora.\nDebitis blanditiis dolores dolor delectus sed assumenda non mollitia sapiente.",
                            Name = "ut",
                            Needs = "high",
                            UpdatedAt = new DateTime(2022, 7, 17, 15, 58, 24, 244, DateTimeKind.Local).AddTicks(3298),
                            Will = "high"
                        },
                        new
                        {
                            Id = new Guid("05c6b0ca-01f2-fd3b-b602-65e5d4aec950"),
                            CreatedAt = new DateTime(2022, 12, 14, 6, 45, 18, 542, DateTimeKind.Local).AddTicks(2104),
                            Decadency = "low",
                            Description = "Enim iste veritatis recusandae quia reiciendis ducimus totam ipsa.\nNemo consequuntur magnam accusantium accusantium sed aut non dolor.\nSed eaque aut facilis voluptates nemo officia minima sit.\nDelectus cupiditate dicta nobis maxime esse qui sit nulla consequuntur.\nVeniam dolor ipsam quod eius deleniti quas.\nVoluptatem magnam dolorem id aut consequatur magnam exercitationem ut magnam.\nIllum amet et porro ullam ducimus animi.\nBlanditiis nulla similique delectus et itaque.\nEt laudantium cupiditate eum saepe alias.\nRepellat nihil voluptates sint aliquid.\nError atque sint velit reiciendis ipsa placeat itaque consequatur.\nEst debitis ullam rerum hic.",
                            Name = "perspiciatis",
                            Needs = "low",
                            Will = "low"
                        },
                        new
                        {
                            Id = new Guid("2bf5e394-cf61-69cc-d7b3-f81355c167df"),
                            CreatedAt = new DateTime(2023, 1, 2, 19, 59, 34, 786, DateTimeKind.Local).AddTicks(8037),
                            Decadency = "medium",
                            Description = "Et adipisci cupiditate pariatur sapiente et voluptates aut at sit.\nMolestiae voluptate expedita.\nVelit excepturi cum.\nAspernatur omnis voluptatem dolor.\nPorro cupiditate dicta laborum harum consequatur ea illum perspiciatis quis.\nDebitis qui et modi ea nulla eum.\nEius tempora sed in ipsa.\nUnde hic quasi occaecati provident velit odit.\nMolestiae tempore placeat atque maiores.\nQuia rerum ea officiis rerum ut.\nQui inventore odio eveniet saepe dolorem facere.\nFacere sapiente inventore distinctio sunt.",
                            Name = "commodi",
                            Needs = "medium",
                            UpdatedAt = new DateTime(2022, 3, 29, 17, 38, 21, 880, DateTimeKind.Local).AddTicks(4514),
                            Will = "high"
                        });
                });

            modelBuilder.Entity("Models.Goods.GoodEntity", b =>
                {
                    b.HasOne("Models.Races.RaceEntity", "Producer")
                        .WithMany("Products")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("Models.Races.RaceEntity", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
