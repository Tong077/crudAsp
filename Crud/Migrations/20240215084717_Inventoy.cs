using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud.Migrations
{
    /// <inheritdoc />
    public partial class Inventoy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sstaffs_StaffId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categorysCategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Sstaffs_staffsStaffId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Products_categorysCategoryID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sstaffs",
                table: "Sstaffs");

            migrationBuilder.DropColumn(
                name: "categorysCategoryID",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Sstaffs",
                newName: "Staffs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Staffs_StaffId",
                table: "Orders",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Staffs_staffsStaffId",
                table: "Stores",
                column: "staffsStaffId",
                principalTable: "Staffs",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Staffs_StaffId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Staffs_staffsStaffId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "Sstaffs");

            migrationBuilder.AddColumn<int>(
                name: "categorysCategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sstaffs",
                table: "Sstaffs",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categorysCategoryID",
                table: "Products",
                column: "categorysCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sstaffs_StaffId",
                table: "Orders",
                column: "StaffId",
                principalTable: "Sstaffs",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categorysCategoryID",
                table: "Products",
                column: "categorysCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Sstaffs_staffsStaffId",
                table: "Stores",
                column: "staffsStaffId",
                principalTable: "Sstaffs",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
