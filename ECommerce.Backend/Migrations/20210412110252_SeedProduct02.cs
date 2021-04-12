using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Backend.Migrations
{
    public partial class SeedProduct02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Microsoft");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 932, DateTimeKind.Local).AddTicks(4124), new DateTime(2021, 4, 12, 18, 2, 51, 934, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "CreatedDate", "Description", "Images", "Price", "ProductName", "UnitsInStock", "UnitsOnOrder", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, 1, 1, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2339), "Florence is a heartfelt experience that lasts around 30 minutes. It's short, but deeply meaningful. At 25, Florence Yeoh feels a little stuck. Her life is an endless routine of work, sleep, and spending too much time on social media. Then one day, she meets a cello player named Krish who changes everything about how she sees the world. Experience every beat of Florence and Krish’s relationship through a series of bespoke gameplay vignettes – from flirting to fighting, from helping each other grow to growing apart. Drawing inspiration from ‘slice of life’ graphic novels and webcomics, Florence is intimate, raw and personal. Original soundtrack included.", "florence-switch-cover.jpg", 4.99m, "Florence", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2361) },
                    { 3, 1, 1, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2372), "The game follows Jill Valentine as she attempts to escape a zombie outbreak while hunted by an intelligent bioweapon known as Nemesis-T Type. The game comes bundled with Resident Evil: Resistance, an online asymmetrical game. ", "resident-evil-3-switch-cover.jpg", 59.99m, "Resident Evil 3 Remake", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2374) },
                    { 4, 2, 2, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2379), "Grand Theft Auto V for PC offers players the option to explore the award-winning world of Los Santos and Blaine County in resolutions of up to 4k and beyond, as well as the chance to experience the game running at 60 frames per second. ", "grand-theft-auto-v-cover.jpg", 34.99m, "Grand Theft Auto V", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2381) },
                    { 5, 3, 2, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2385), "Embark on the craziest journey of your life in It Takes Two. Invite a friend to join for free with Friend’s Pass and work together across a huge variety of gleefully disruptive gameplay challenges. ", "it-takes-two-english-only-cover.jpg", 34.99m, "It Takes Two", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2387) },
                    { 6, 2, 2, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2391), "Ushering in a new era for the METAL GEAR franchise with cutting-edge technology powered by the Fox Engine, METAL GEAR SOLID V: The Phantom Pain, will provide players a first-rate gaming experience as they are offered tactical freedom to carry out open-world missions. ", "metal-gear-solid-v-the-phantom-pain.jpg", 29.99m, "Metal Gear Solid V - The Phantom Pain", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2393) },
                    { 7, 2, 2, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2398), "Outriders’ brutal and bloody combat combines frenetic gunplay, violent powers and deep RPG systems to create a true genre hybrid. ", "outriders-cover.jpg", 59.99m, "Outriders", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2400) },
                    { 8, 2, 2, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2404), "Experience survival horror like never before in the 8th major installment in the Resident Evil franchise - Resident Evil Village. With detailed graphics, intense first-person action and masterful storytelling, the terror has never felt more realistic. ", "resident-evil-village-deluxe-edition-cover.jpg", 59.99m, "Resident Evil Village", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2406) },
                    { 9, 3, 2, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2412), "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world.", "the-witcher-3.jpg", 19.99m, "The Witcher 3", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2414) },
                    { 10, 4, 3, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2418), "The story of this first, standalone game in the FINAL FANTASY VII REMAKE project covers up to the party’s escape from Midgar, and goes deeper into the events occurring in Midgar than the original FINAL FANTASY VII.", "final-fantasy-vii-remake-ps4-cover.jpg", 59.99m, "Final Fantasy VII Remake", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2420) },
                    { 11, 4, 3, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2425), "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world. ", "god-of-war-4.jpg", 49.99m, "God Of War 4", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2427) },
                    { 12, 4, 3, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2431), "Battle hordes of yokai in this masocore Action RPG. Create your protagonist and embark on an adventure through a myriad of locales across Japan during the Sengoku period. Utilize the new Yokai Shift ability to defeat even the most ferocious yokai and be prepared to brave through Dark Realms created by your...", "nioh-2-the-complete-edition-ps4-cover.jpg", 49.99m, "Nioh 2", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2433) },
                    { 13, 4, 3, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2437), "Release in 2022", "dragon-quest-iii-remake-ps5.jpg", 49.99m, "Dragon Quest III Remake", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2440) },
                    { 14, 5, 4, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2444), "Release in 2022", "assassin-2019s-creed-valhalla.jpg", 49.99m, "Assassin Creed Valhalla", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2446) },
                    { 15, 5, 4, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2452), "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world. ", "the-witcher-3-xbox.jpg", 19.99m, "The Witcher 3", 10, 0, new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2454) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Xbox");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 17, 2, 0, 866, DateTimeKind.Local).AddTicks(695), new DateTime(2021, 4, 12, 17, 2, 0, 867, DateTimeKind.Local).AddTicks(2011) });
        }
    }
}
