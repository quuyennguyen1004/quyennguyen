using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webb.Models;
using Webb.Views.Domain;

namespace Webb.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext>
options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder
        builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
            new Category()
            {
                CategoryId = 1,
                CategoryName = "Iphone"
            },
            new Category()
            {
                CategoryId = 2,
                CategoryName = "SamSung"
            },
             new Category()
             {
                 CategoryId = 3,
                 CategoryName = "Oppo"
             },
             new Category()
             {
                 CategoryId = 4,
                 CategoryName = "Xiaomi"
             });
            builder.Entity<Product>().HasData(
            new Product()
            {
                ProductId = 1,
                ProductName = "IphoneX",
                ProductImage = "ip.png",
                Color = "Black",
                Ram = "3GB",
                Batterycapacity = "2716 mAh",
                Screen = "OLED, 5.8 Super Retina",
                Frontcamera = "7 MP",
                Rearcamera = "2 camera 12 MP",
                Chipset = "Apple A11 Bionic 6 nhân",
                Descriptions = "iphoneX 256GB",
                ProductQuantity = 100,
                ProductPrice = 500.00,
                CreateDate = DateTime.Now,
                CategoryId = 1
            },
           new Product()
           {
               ProductId = 2,
               ProductName = "Iphone 8 Plus",
               ProductImage = "ip.png",
               Color = "Gold",
               Ram = "3 GB",
               Batterycapacity = "2691 mAh",
               Screen = "Full HD (1080 x 1920 pixels)",
               Frontcamera = "7 MP",
               Rearcamera = "2 camera 12 MP",
               Chipset = "Apple A11 Bionic",
               Descriptions = "iphone8+ 64GB",
               ProductQuantity = 90,
               ProductPrice = 200.00,
               CreateDate = DateTime.Now,
               CategoryId = 1
           },
           new Product()
           {
               ProductId = 3,
               ProductName = "Iphone 11 ProMax",
               ProductImage = "ip.png",
               Color = "Black",
               Ram = "4 GB",
               Batterycapacity = "3.969 mAh",
               Screen = " OLED",
               Frontcamera = "12 MP, f/2.2",
               Rearcamera = "12 MP + 12 MP + 12 MP",
               Chipset = "Apple A13 Bionic",
               Descriptions = "iphone11 ProMax 512GB",
               ProductQuantity = 26,
               ProductPrice = 700.00,
               CreateDate = DateTime.Now,
               CategoryId = 1
           },
           new Product()
           {
               ProductId = 4,
               ProductName = "SamSung Galaxy Note9",
               ProductImage = "ip.png",
               Color = "Blue",
               Ram = "6GB",
               Batterycapacity = "4000 mAh",
               Screen = "Super AMOLED, 6.4, Quad HD + (2K +)",
               Frontcamera = "8 MP",
               Rearcamera = "2 camera 12 MP",
               Chipset = "Exynos 9810 8 nhân 64 bit",
               Descriptions = "SamSung Note 9-128GB ",
               ProductQuantity = 46,
               ProductPrice = 550.00,
               CreateDate = DateTime.Now,
               CategoryId = 2
           },
             new Product()
             {
                 ProductId = 5,
                 ProductName = "SamSung Galaxy S10",
                 ProductImage = "ip.png",
                 Color = "Black",
                 Ram = "8GB",
                 Batterycapacity = "4500 mAh",
                 Screen = "Dynamic AMOLED 6.7'' FullHD+ , 16 triệu màu",
                 Frontcamera = "24 MP & 10MP & 8 MP (3 camera)",
                 Rearcamera = "10 MP & TOF 3D ( 2 Camera )",
                 Chipset = "Exynos 9820 8 nhân 64-bit",
                 Descriptions = "SamSung S10-256GB ",
                 ProductQuantity = 98,
                 ProductPrice = 720.00,
                 CreateDate = DateTime.Now,
                 CategoryId = 2
             },
             new Product()
             {
                 ProductId = 6,
                 ProductName = "Oppo A92",
                 ProductImage = "ip.png",
                 Color = "White",
                 Ram = "8GB",
                 Batterycapacity = "5000 mAh",
                 Screen = "IPS LCD, 6.5,Full HD + ",
                 Frontcamera = "16 MP",
                 Rearcamera = "Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP",
                 Chipset = "Snapdragon 665 8 nhân",
                 Descriptions = "OppoA92-256GB ",
                 ProductQuantity = 92,
                 ProductPrice = 192.00,
                 CreateDate = DateTime.Now,
                 CategoryId = 3
             },
             new Product()
             {
                 ProductId = 7,
                 ProductName = "Oppo Reno3",
                 ProductImage = "ip.png",
                 Color = "Pink",
                 Ram = "8GB",
                 Batterycapacity = "4025 mAh",
                 Screen = "AMOLED, 6.4, Full HD + ",
                 Frontcamera = "44 MP",
                 Rearcamera = "Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP",
                 Chipset = "MediaTek Helio P90 8 nhân",
                 Descriptions = "Oppo Reno3-256GB ",
                 ProductQuantity = 70,
                 ProductPrice = 300.00,
                 CreateDate = DateTime.Now,
                 CategoryId = 3
             },
             new Product()
             {
                 ProductId = 8,
                 ProductName = "XiaoMi Black Shark3",
                 ProductImage = "ip.png",
                 Color = "Black",
                 Ram = "8GB",
                 Batterycapacity = "4720 mAh",
                 Screen = "Amoled",
                 Frontcamera = "20 MP, f/2.2",
                 Rearcamera = "camera chính 64 MP f/1.8, camera góc rộng 13 MP f/2.25, Portrait mode 5 MP f/2.2",
                 Chipset = "Qualcomm Adreno 650",
                 Descriptions = "Xiaomi Black Shark3-128GB ",
                 ProductQuantity = 22,
                 ProductPrice = 600.00,
                 CreateDate = DateTime.Now,
                 CategoryId = 4
             });
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Visitor",
                    NormalizedName = "VISITOR"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR".ToUpper()
                });
        }

        public DbSet<Webb.Models.PurcharseHis> PurcharseHis { get; set; }
    }
}
