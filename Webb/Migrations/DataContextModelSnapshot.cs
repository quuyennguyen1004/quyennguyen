﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webb.Data;

namespace Webb.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "d0c0815b-0c02-479b-b33d-3105217e5103",
                            ConcurrencyStamp = "4a787677-7903-4b87-8ed2-7b0122ebfed4",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        },
                        new
                        {
                            Id = "8c92be80-eed5-480c-a430-452ada4f0d5c",
                            ConcurrencyStamp = "937b717f-6ba0-4b9f-ae78-0fb7442f0af0",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Webb.Models.PurcharseHis", b =>
                {
                    b.Property<int>("PurcharseHisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("PurcharseHisId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("PurcharseHis");
                });

            modelBuilder.Entity("Webb.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dienthoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Webb.Views.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Iphone"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "SamSung"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Oppo"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Xiaomi"
                        });
                });

            modelBuilder.Entity("Webb.Views.Domain.Comment", b =>
                {
                    b.Property<int>("ComId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ComId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Webb.Views.Domain.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("isConfirm")
                        .HasColumnType("bit");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Webb.Views.Domain.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Webb.Views.Domain.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Batterycapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Chipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frontcamera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Ram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rearcamera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Batterycapacity = "2716 mAh",
                            CategoryId = 1,
                            Chipset = "Apple A11 Bionic 6 nhân",
                            Color = "Black",
                            CreateDate = new DateTime(2021, 7, 9, 20, 45, 27, 585, DateTimeKind.Local).AddTicks(4958),
                            Descriptions = "iphoneX 256GB",
                            Frontcamera = "7 MP",
                            ProductImage = "ip.png",
                            ProductName = "IphoneX",
                            ProductPrice = 500.0,
                            ProductQuantity = 100,
                            Ram = "3GB",
                            Rearcamera = "2 camera 12 MP",
                            Screen = "OLED, 5.8 Super Retina"
                        },
                        new
                        {
                            ProductId = 2,
                            Batterycapacity = "2691 mAh",
                            CategoryId = 1,
                            Chipset = "Apple A11 Bionic",
                            Color = "Gold",
                            CreateDate = new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3566),
                            Descriptions = "iphone8+ 64GB",
                            Frontcamera = "7 MP",
                            ProductImage = "ip.png",
                            ProductName = "Iphone 8 Plus",
                            ProductPrice = 200.0,
                            ProductQuantity = 90,
                            Ram = "3 GB",
                            Rearcamera = "2 camera 12 MP",
                            Screen = "Full HD (1080 x 1920 pixels)"
                        },
                        new
                        {
                            ProductId = 3,
                            Batterycapacity = "3.969 mAh",
                            CategoryId = 1,
                            Chipset = "Apple A13 Bionic",
                            Color = "Black",
                            CreateDate = new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3596),
                            Descriptions = "iphone11 ProMax 512GB",
                            Frontcamera = "12 MP, f/2.2",
                            ProductImage = "ip.png",
                            ProductName = "Iphone 11 ProMax",
                            ProductPrice = 700.0,
                            ProductQuantity = 26,
                            Ram = "4 GB",
                            Rearcamera = "12 MP + 12 MP + 12 MP",
                            Screen = " OLED"
                        },
                        new
                        {
                            ProductId = 4,
                            Batterycapacity = "4000 mAh",
                            CategoryId = 2,
                            Chipset = "Exynos 9810 8 nhân 64 bit",
                            Color = "Blue",
                            CreateDate = new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3600),
                            Descriptions = "SamSung Note 9-128GB ",
                            Frontcamera = "8 MP",
                            ProductImage = "ip.png",
                            ProductName = "SamSung Galaxy Note9",
                            ProductPrice = 550.0,
                            ProductQuantity = 46,
                            Ram = "6GB",
                            Rearcamera = "2 camera 12 MP",
                            Screen = "Super AMOLED, 6.4, Quad HD + (2K +)"
                        },
                        new
                        {
                            ProductId = 5,
                            Batterycapacity = "4500 mAh",
                            CategoryId = 2,
                            Chipset = "Exynos 9820 8 nhân 64-bit",
                            Color = "Black",
                            CreateDate = new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3602),
                            Descriptions = "SamSung S10-256GB ",
                            Frontcamera = "24 MP & 10MP & 8 MP (3 camera)",
                            ProductImage = "ip.png",
                            ProductName = "SamSung Galaxy S10",
                            ProductPrice = 720.0,
                            ProductQuantity = 98,
                            Ram = "8GB",
                            Rearcamera = "10 MP & TOF 3D ( 2 Camera )",
                            Screen = "Dynamic AMOLED 6.7'' FullHD+ , 16 triệu màu"
                        },
                        new
                        {
                            ProductId = 6,
                            Batterycapacity = "5000 mAh",
                            CategoryId = 3,
                            Chipset = "Snapdragon 665 8 nhân",
                            Color = "White",
                            CreateDate = new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3603),
                            Descriptions = "OppoA92-256GB ",
                            Frontcamera = "16 MP",
                            ProductImage = "ip.png",
                            ProductName = "Oppo A92",
                            ProductPrice = 192.0,
                            ProductQuantity = 92,
                            Ram = "8GB",
                            Rearcamera = "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP",
                            Screen = "IPS LCD, 6.5,Full HD + "
                        },
                        new
                        {
                            ProductId = 7,
                            Batterycapacity = "4025 mAh",
                            CategoryId = 3,
                            Chipset = "MediaTek Helio P90 8 nhân",
                            Color = "Pink",
                            CreateDate = new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3605),
                            Descriptions = "Oppo Reno3-256GB ",
                            Frontcamera = "44 MP",
                            ProductImage = "ip.png",
                            ProductName = "Oppo Reno3",
                            ProductPrice = 300.0,
                            ProductQuantity = 70,
                            Ram = "8GB",
                            Rearcamera = "Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP",
                            Screen = "AMOLED, 6.4, Full HD + "
                        },
                        new
                        {
                            ProductId = 8,
                            Batterycapacity = "4720 mAh",
                            CategoryId = 4,
                            Chipset = "Qualcomm Adreno 650",
                            Color = "Black",
                            CreateDate = new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3607),
                            Descriptions = "Xiaomi Black Shark3-128GB ",
                            Frontcamera = "20 MP, f/2.2",
                            ProductImage = "ip.png",
                            ProductName = "XiaoMi Black Shark3",
                            ProductPrice = 600.0,
                            ProductQuantity = 22,
                            Ram = "8GB",
                            Rearcamera = "camera chính 64 MP f/1.8, camera góc rộng 13 MP f/2.25, Portrait mode 5 MP f/2.2",
                            Screen = "Amoled"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Webb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Webb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Webb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webb.Models.PurcharseHis", b =>
                {
                    b.HasOne("Webb.Views.Domain.Order", "Order")
                        .WithMany("PurcharseHiss")
                        .HasForeignKey("OrderId");

                    b.HasOne("Webb.Views.Domain.Product", null)
                        .WithMany("PurcharseHiss")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Webb.Views.Domain.Comment", b =>
                {
                    b.HasOne("Webb.Views.Domain.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId");

                    b.HasOne("Webb.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Webb.Views.Domain.Order", b =>
                {
                    b.HasOne("Webb.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Webb.Views.Domain.OrderDetail", b =>
                {
                    b.HasOne("Webb.Views.Domain.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webb.Views.Domain.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Webb.Views.Domain.Product", b =>
                {
                    b.HasOne("Webb.Views.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Webb.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Webb.Views.Domain.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Webb.Views.Domain.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("PurcharseHiss");
                });

            modelBuilder.Entity("Webb.Views.Domain.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("OrderDetails");

                    b.Navigation("PurcharseHiss");
                });
#pragma warning restore 612, 618
        }
    }
}
