using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class SeedMonWeapon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponId", "CreatedDate", "Description", "Force", "Image", "Name", "Price", "Qty", "QtyBought" },
                values: new object[] { 3, new DateTime(2016, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "A vibranium gun", 300m, "https://marvelcinematicuniverse.fandom.com/wiki/Arnimhilation_99L_Assault_Weapon", "Vibratiqx", 700m, 5, 12 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3);
        }
    }
}
