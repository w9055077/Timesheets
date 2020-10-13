using Microsoft.EntityFrameworkCore.Migrations;

namespace Excercise_3_Timesheets.Migrations
{
    public partial class AddStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Locations",
                newName: "LocationId");

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(nullable: true),
                    Forename = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Email", "Forename", "Surname" },
                values: new object[,]
                {
                    { 1, "Joedinsley31@gmail.com", "Joe", "Dinsley" },
                    { 2, "Stefansmith1@gmail.com", "Stefan", "Smith" },
                    { 3, "Jamiequaker4808@gmail.com", "Jamie", "Quaker" },
                    { 4, "Skyestevenson0@gmail.com", "Skye", "Stevenson" },
                    { 5, "Davidatkinson111@gmail.com", "David", "Atkinson" },
                    { 6, "Garyridley007@gmail.com", "Gary", "Ridley" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Locations",
                newName: "LocationID");
        }
    }
}
