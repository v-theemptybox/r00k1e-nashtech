using ECommerce.Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace ECommerce.Backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .ToTable("AspNetUsers");

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1, 
                    CategoryName = "Switch",
                    Description = "The Nintendo Switch (known as the NX in development) is a eighth generation home video game console released by Nintendo, and its seventh major home game console as the successor to the Wii U."
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "PC",
                    Description = "Stands for 'Personal computer'. PCs are what most of us use on a daily basis for work or personal use. A typical PC includes a system unit, monitor, keyboard, and mouse."
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "PlayStation",
                    Description = "PS is a video game brand that consists of five home video game consoles, as well as a media center, an online service, a line of controllers, two handhelds and a phone, as well as multiple magazines."
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Xbox",
                    Description = "The brand consists of five video game consoles, as well as applications (games), streaming services, an online service by the name of Xbox Live, and the development arm by the name of Xbox Game Studios."
                }
                );
            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Amazon"
                },
                new Brand
                {
                    Id = 2,
                    Name = "Steam"
                },
                new Brand
                {
                    Id = 3,
                    Name = "Epic"
                },
                new Brand
                {
                    Id = 4,
                    Name = "Sony"
                },
                new Brand
                {
                    Id = 5,
                    Name = "Microsoft"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Persona 5 - Scramble Striker",
                    CategoryId = 1,
                    Description = "Join the Phantom Thieves and strike back against the corruption overtaking cities across Japan. A summer vacation with close friends takes a sudden turn as a distorted reality emerges; reveal the truth and redeem the hearts of those imprisoned at the center of the crisis! Jump into the stylish world of Persona in an all-new story Dynamically control your team during explosive action combat Battle across Japan in an epic road trip Key Features Include: " +
                    "/nExperience the world of Persona 5 Strikers on PC in Full HD, supports up to 4K " +
                    "/nSteam Achievements and Trading Cards " +
                    "/nChoose between Japanese and English VO " +
                    "/nFull keyboard and mouse adaptation",
                    Price = new Decimal(59.99),
                    Images = "persona-5-scramble-strikers-switch.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 1
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Florence",
                    CategoryId = 1,
                    Description = "Florence is a heartfelt experience that lasts around 30 minutes. It's short, but deeply meaningful. At 25, Florence Yeoh feels a little stuck. Her life is an endless routine of work, sleep, and spending too much time on social media. Then one day, she meets a cello player named Krish who changes everything about how she sees the world. Experience every beat of Florence and Krish’s relationship through a series of bespoke gameplay vignettes – from flirting to fighting, from helping each other grow to growing apart. Drawing inspiration from ‘slice of life’ graphic novels and webcomics, Florence is intimate, raw and personal. Original soundtrack included.",
                    Price = new Decimal(4.99),
                    Images = "florence-switch-cover.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 1
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Resident Evil 3 Remake",
                    CategoryId = 1,
                    Description = "The game follows Jill Valentine as she attempts to escape a zombie outbreak while hunted by an intelligent bioweapon known as Nemesis-T Type. The game comes bundled with Resident Evil: Resistance, an online asymmetrical game. ",
                    Price = new Decimal(59.99),
                    Images = "resident-evil-3-switch-cover.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 1
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Grand Theft Auto V",
                    CategoryId = 2,
                    Description = "Grand Theft Auto V for PC offers players the option to explore the award-winning world of Los Santos and Blaine County in resolutions of up to 4k and beyond, as well as the chance to experience the game running at 60 frames per second. ",
                    Price = new Decimal(34.99),
                    Images = "grand-theft-auto-v-cover.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 2
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "It Takes Two",
                    CategoryId = 2,
                    Description = "Embark on the craziest journey of your life in It Takes Two. Invite a friend to join for free with Friend’s Pass and work together across a huge variety of gleefully disruptive gameplay challenges. ",
                    Price = new Decimal(34.99),
                    Images = "it-takes-two-english-only-cover.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 3
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "Metal Gear Solid V - The Phantom Pain",
                    CategoryId = 2,
                    Description = "Ushering in a new era for the METAL GEAR franchise with cutting-edge technology powered by the Fox Engine, METAL GEAR SOLID V: The Phantom Pain, will provide players a first-rate gaming experience as they are offered tactical freedom to carry out open-world missions. ",
                    Price = new Decimal(29.99),
                    Images = "metal-gear-solid-v-the-phantom-pain.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 2
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "Outriders",
                    CategoryId = 2,
                    Description = "Outriders’ brutal and bloody combat combines frenetic gunplay, violent powers and deep RPG systems to create a true genre hybrid. ",
                    Price = new Decimal(59.99),
                    Images = "outriders-cover.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 2
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "Resident Evil Village",
                    CategoryId = 2,
                    Description = "Experience survival horror like never before in the 8th major installment in the Resident Evil franchise - Resident Evil Village. With detailed graphics, intense first-person action and masterful storytelling, the terror has never felt more realistic. ",
                    Price = new Decimal(59.99),
                    Images = "resident-evil-village-deluxe-edition-cover.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 2
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "The Witcher 3",
                    CategoryId = 2,
                    Description = "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world.",
                    Price = new Decimal(19.99),
                    Images = "the-witcher-3.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 3
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "Final Fantasy VII Remake",
                    CategoryId = 3,
                    Description = "The story of this first, standalone game in the FINAL FANTASY VII REMAKE project covers up to the party’s escape from Midgar, and goes deeper into the events occurring in Midgar than the original FINAL FANTASY VII.",
                    Price = new Decimal(59.99),
                    Images = "final-fantasy-vii-remake-ps4-cover.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 4
                },
                new Product
                {
                    ProductId = 11,
                    ProductName = "God Of War 4",
                    CategoryId = 3,
                    Description = "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world. ",
                    Price = new Decimal(49.99),
                    Images = "god-of-war-4.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 4
                },
                new Product
                {
                    ProductId = 12,
                    ProductName = "Nioh 2",
                    CategoryId = 3,
                    Description = "Battle hordes of yokai in this masocore Action RPG. Create your protagonist and embark on an adventure through a myriad of locales across Japan during the Sengoku period. Utilize the new Yokai Shift ability to defeat even the most ferocious yokai and be prepared to brave through Dark Realms created by your...",
                    Price = new Decimal(49.99),
                    Images = "nioh-2-the-complete-edition-ps4-cover.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 4
                },
                new Product
                {
                    ProductId = 13,
                    ProductName = "Dragon Quest III Remake",
                    CategoryId = 3,
                    Description = "Release in 2022",
                    Price = new Decimal(49.99),
                    Images = "dragon-quest-iii-remake-ps5.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 4
                },
                new Product
                {
                    ProductId = 14,
                    ProductName = "Assassin Creed Valhalla",
                    CategoryId = 4,
                    Description = "Become Eivor, a Viking raider raised to be a fearless warrior, and lead your clan from icy desolation in Norway to a new home amid the lush farmlands of ninth-century England. Find your settlement and conquer this hostile land by any means to earn a place in Valhalla." +
                    "England in the age of the Vikings is a fractured nation of petty lords and warring kingdoms.Beneath the chaos lies a rich and untamed land waiting for a new conqueror.Will it be you ? ",
                    Price = new Decimal(49.99),
                    Images = "assassin-2019s-creed-valhalla.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 5
                },
                new Product
                {
                    ProductId = 15,
                    ProductName = "The Witcher 3",
                    CategoryId = 4,
                    Description = "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world. ",
                    Price = new Decimal(19.99),
                    Images = "the-witcher-3-xbox.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandId = 5
                }
                );
        }
        
    }
}
