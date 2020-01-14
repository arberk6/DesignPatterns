using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApp.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "userType",
            //    columns: table => new
            //    {
            //        usertypeid = table.Column<int>(nullable: false),
            //        type = table.Column<string>(unicode: false, maxLength: 15, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_userType", x => x.usertypeid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Person",
            //    columns: table => new
            //    {
            //        personID = table.Column<int>(nullable: false),
            //        name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        lastname = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        age = table.Column<int>(nullable: false),
            //        type = table.Column<int>(nullable: true),
            //        Usertypeid = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Person", x => x.personID);
            //        table.ForeignKey(
            //            name: "FK_Person_userType_Usertypeid",
            //            column: x => x.Usertypeid,
            //            principalTable: "userType",
            //            principalColumn: "usertypeid",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Person_Usertypeid",
                table: "Person",
                column: "Usertypeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "userType");
        }
    }
}
