using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication10.Data.Migrations
{
    public partial class Initial2 : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.RenameColumn(
                name: "City_ID",
                table: "City",
                newName: "ID");
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "City",
                newName: "City_ID");


        }



    }
}
