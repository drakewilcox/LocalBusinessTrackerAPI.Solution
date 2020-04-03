using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessTrackerAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Locations",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Address", "Description", "Hours", "Name", "Phone", "Rating", "Type", "Website" },
                values: new object[,]
                {
                    { 1, "126 SW 2nd Ave", "Spanish Style Rotissere Chicken, Specialty Cocktails and Tapas", "Everyday 11AM to 10PM", "Pollo Bravo", "503.477.8899", 5, "Restaurant", "http://www.pollobravopdx.com/" },
                    { 2, "2216 NE MLK Blvd", "A Springboard for Bad Decisions", "Everyday NOON to 2AM", "Billy Rays Neighborhood Dive", "503.287.7254", 4, "Bar", "none" },
                    { 3, "8630 N Lombard St.", "Taqueria, Bakery and Grocery Store in St. Johns", "Everyday 11AM to 10PM", "Tienda Santa Cruz", "503.286.7302", 4, "Restaurant", "none" },
                    { 4, "720 SE Sandy Blvd", "Specialty Cocktail Lounge", "Everyday 4 to 2AM", "Rum Club", "503.265.8807", 5, "Bar", "rumclubpdx.com" },
                    { 5, "5202 N Albina Ave", "Small Independent Record Store and Label", "Everyday 12PM to 7PM", "Mississippi Records", "503.282.2990", 5, "Retail", "none" },
                    { 6, "720 N Killingsworth  St.", "Used, Vintage, & Consignment Store", "THU - TUE 11AM - 6PM", "Zero Wave", "971.266.3492", 4, "Retail", "none" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Locations");
        }
    }
}
