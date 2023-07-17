﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Application.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDark = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Desserts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desserts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desserts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    DrinkId = table.Column<int>(type: "int", nullable: true),
                    FriesId = table.Column<int>(type: "int", nullable: true),
                    HamburgerId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sauce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sauce_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drinks_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Drinks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Frieses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frieses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frieses_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Frieses_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hamburger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamburger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hamburger_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Hamburger_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "85e2cf6b-564c-43f4-a12e-c9d5e43b4028", new DateTime(2023, 7, 17, 13, 10, 48, 380, DateTimeKind.Local).AddTicks(9098), "Admin", "ADMIN" },
                    { 2, "dc52132c-b0e0-42a1-a640-62cf72ac7c74", new DateTime(2023, 7, 17, 13, 10, 48, 380, DateTimeKind.Local).AddTicks(9111), "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "Id", "CreationTime", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(3534), "Brownie", null, "cafddece-875e-4d0c-830c-72b3e194666c_Brownie.jpg", 50m },
                    { 2, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(3541), "Milkshake", null, "fb998a43-9809-4ebc-a546-ce63ca896be8_MilkShake.jpg", 40m },
                    { 3, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(3543), "Cheesecake", null, "ee446133-2bb0-46af-b257-3d1a8930432f_CheeseCake.jpg", 60m },
                    { 4, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(3545), "Ice Cream", null, "1d5c1238-10f9-49e6-a388-a541d1d64e4c_IcaCream.jpg", 30m },
                    { 5, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(3546), "Puding", null, "a01529c3-70cf-4b43-af5c-db1f8f9a921d_Puding.jpg", 40m }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5195), null, "Coke-S", null, "6240f4b6-c927-4898-9c76-6968b54c1e39_Coke.jpg", 40m },
                    { 2, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5200), null, "Ayran-S", null, "a7e28042-2e4a-443e-860d-0f0cbd0d640c_Ayran.jpg", 25m },
                    { 3, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5201), null, "Coke Zero-S", null, "1117576e-e2a3-42a5-8dc0-9f5d90fd0e80_CokeZero.jpg", 45m },
                    { 4, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5203), null, "Cold Tea-S", null, "914e854b-f076-455c-aeab-49f8d8f4ca8e_ColdTea.jpg", 35m },
                    { 5, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5204), null, "Mineral Water-S", null, "d2ffceeb-e929-43e1-9fc6-df7838fa6aa2_MineralWater.jpg", 15m }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Price", "Size" },
                values: new object[,]
                {
                    { 6, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5206), null, "Coke-M", null, "6240f4b6-c927-4898-9c76-6968b54c1e39_Coke.jpg", 45m, 2 },
                    { 7, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5207), null, "Ayran-M", null, "a7e28042-2e4a-443e-860d-0f0cbd0d640c_Ayran.jpg", 30m, 2 },
                    { 8, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5209), null, "Coke Zero-M", null, "1117576e-e2a3-42a5-8dc0-9f5d90fd0e80_CokeZero.jpg", 50m, 2 },
                    { 9, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5210), null, "Cold Tea-M", null, "914e854b-f076-455c-aeab-49f8d8f4ca8e_ColdTea.jpg", 40m, 2 },
                    { 10, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5211), null, "Mineral Water-M", null, "d2ffceeb-e929-43e1-9fc6-df7838fa6aa2_MineralWater.jpg", 20m, 2 },
                    { 11, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5212), null, "Coke-L", null, "6240f4b6-c927-4898-9c76-6968b54c1e39_Coke.jpg", 50m, 3 },
                    { 12, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5214), null, "Ayran-L", null, "a7e28042-2e4a-443e-860d-0f0cbd0d640c_Ayran.jpg", 35m, 3 },
                    { 13, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5215), null, "Coke Zero-L", null, "1117576e-e2a3-42a5-8dc0-9f5d90fd0e80_CokeZero.jpg", 55m, 3 },
                    { 14, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5216), null, "Cold Tea-L", null, "914e854b-f076-455c-aeab-49f8d8f4ca8e_ColdTea.jpg", 45m, 3 },
                    { 15, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(5217), null, "Mineral Water-L", null, "d2ffceeb-e929-43e1-9fc6-df7838fa6aa2_MineralWater.jpg", 25m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Frieses",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(6966), null, "Potatoes - S", null, "301422bb-3c9f-4670-87ec-52f6bb49510e_Potatoes.jpg", 20m },
                    { 2, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(6970), null, "Onion Ring - S", null, "40149d5b-324f-40d3-802c-0866bc9edac8_OnionRings.jpg", 22m },
                    { 3, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7011), null, "Nugget - S", null, "f012288d-4cb5-4546-a5a1-82a2e34457ce_Nuggets.jpg", 25m },
                    { 4, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7013), null, "Chicken Tenders - S", null, "1e165d0c-cdad-4956-a803-a291756320b1_ChickenTenders.jpg", 25m }
                });

            migrationBuilder.InsertData(
                table: "Frieses",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Price", "Size" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7014), null, "Potatoes - M", null, "301422bb-3c9f-4670-87ec-52f6bb49510e_Potatoes.jpg", 24m, 2 },
                    { 6, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7016), null, "Onion Ring - M", null, "40149d5b-324f-40d3-802c-0866bc9edac8_OnionRings.jpg", 26m, 2 },
                    { 7, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7017), null, "Nugget - M", null, "f012288d-4cb5-4546-a5a1-82a2e34457ce_Nuggets.jpg", 29m, 2 },
                    { 8, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7019), null, "Chicken Tenders - M", null, "1e165d0c-cdad-4956-a803-a291756320b1_ChickenTenders.jpg", 29m, 2 },
                    { 9, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7020), null, "Potatoes - L", null, "301422bb-3c9f-4670-87ec-52f6bb49510e_Potatoes.jpg", 28m, 3 },
                    { 10, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7021), null, "Onion Ring - L", null, "40149d5b-324f-40d3-802c-0866bc9edac8_OnionRings.jpg", 30m, 3 },
                    { 11, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7022), null, "Nugget - L", null, "f012288d-4cb5-4546-a5a1-82a2e34457ce_Nuggets.jpg", 33m, 3 },
                    { 12, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(7023), null, "Chicken Tenders - L", null, "1e165d0c-cdad-4956-a803-a291756320b1_ChickenTenders.jpg", 33m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Hamburger",
                columns: new[] { "Id", "CreationTime", "MenuId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(8609), null, "Whopper", null, "27c952d4-c958-4bce-87ad-6cb40a743067_Whopper.jpg", 120m },
                    { 2, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(8614), null, "Texas SmokeHouse", null, "43773966-353c-4741-9a0e-9d3642aea7e3_TexasSmokeHouse.jpg", 140m },
                    { 3, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(8616), null, "Fish Royale", null, "074e56a6-ab87-48b1-b948-8ddc5ff84c97_FishRoyale.jpg", 110m },
                    { 4, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(8617), null, "Big King", null, "e7bcba7f-5e1f-4b11-81fe-8f423b4bb26f_BigKing.jpg", 150m },
                    { 5, new DateTime(2023, 7, 17, 13, 10, 48, 381, DateTimeKind.Local).AddTicks(8618), null, "Chicken Royale", null, "0c8d85ff-19e8-4550-b079-f83d1e8b863a_ChickenRoyale.jpg", 95m }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreationTime", "DrinkId", "FriesId", "HamburgerId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(6114), 1, 1, 1, "Whopper Menu", null, "085732b2-62a9-473a-9c94-198bf0b38d9c_WhopperMenu.jpg", 150m },
                    { 2, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(6122), 1, 1, 2, "Texas SmokeHouse Menu", null, "03e49b85-7d1b-4a0e-8d18-47d97756a570_TexasSmokeHouseMenu.jpg", 170m },
                    { 3, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(6124), 1, 1, 3, "Fish Royale Menu", null, "c7e2b9ad-b7b7-476f-9e1d-32c502cf5686_FishRoyaleMenu.jpg", 140m }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreationTime", "DrinkId", "FriesId", "HamburgerId", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(6126), 1, 1, 4, "Big King Menu", null, "3ae527d5-e1ca-474d-b550-9acca3afb9b8_BigKingMenu.jpg", 150m },
                    { 5, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(6127), 1, 1, 5, "Chicken Royale Menu", null, "70e64328-09a0-4e6c-90c5-23868ba18a03_ChickenRoyaleMenu.jpg", 120m }
                });

            migrationBuilder.InsertData(
                table: "Sauce",
                columns: new[] { "Id", "CreationTime", "Name", "OrderId", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(8466), "Ranch", null, "7b5e0551-d08d-4092-8c72-ff370ea64c57_RanchSauce.jpg", 15m },
                    { 2, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(8471), "Ketchup", null, "f8b55022-2756-43dd-823d-6b94e43d9807_KetchupSauce.jpg", 10m },
                    { 3, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(8473), "Mayonnaise", null, "7821c0f8-2b4b-4b46-b958-6fe2dec26bd7_MayonaisseSauce.jpg", 10m },
                    { 4, new DateTime(2023, 7, 17, 13, 10, 48, 383, DateTimeKind.Local).AddTicks(8474), "Barbeque", null, "cad13c53-f4c9-4b94-aaa7-cb20855cd41e_BarbequeSauce.jpg", 15m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Desserts_Name",
                table: "Desserts",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Desserts_OrderId",
                table: "Desserts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_MenuId",
                table: "Drinks",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_Name",
                table: "Drinks",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_OrderId",
                table: "Drinks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Frieses_MenuId",
                table: "Frieses",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Frieses_Name",
                table: "Frieses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Frieses_OrderId",
                table: "Frieses",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Hamburger_MenuId",
                table: "Hamburger",
                column: "MenuId",
                unique: true,
                filter: "[MenuId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Hamburger_Name",
                table: "Hamburger",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hamburger_OrderId",
                table: "Hamburger",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Name",
                table: "Menus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrderId",
                table: "Menus",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sauce_Name",
                table: "Sauce",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sauce_OrderId",
                table: "Sauce",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Desserts");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Frieses");

            migrationBuilder.DropTable(
                name: "Hamburger");

            migrationBuilder.DropTable(
                name: "Sauce");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
