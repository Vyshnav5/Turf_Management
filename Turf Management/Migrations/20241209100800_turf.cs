using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turf_Management.Migrations
{
    /// <inheritdoc />
    public partial class turf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    B_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_id = table.Column<int>(type: "int", nullable: false),
                    C_id = table.Column<int>(type: "int", nullable: false),
                    B_from_time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_To_time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_booking_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_payment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_acc_details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_availability = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.B_id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    C_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    C_ph = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.C_id);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    F_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_id = table.Column<int>(type: "int", nullable: false),
                    F_feedback = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.F_id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    L_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_id = table.Column<int>(type: "int", nullable: false),
                    L_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.L_id);
                });

            migrationBuilder.CreateTable(
                name: "Turf_details",
                columns: table => new
                {
                    T_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    T_ph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    T_from_timing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    T_to_timing = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turf_details", x => x.T_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Turf_details");
        }
    }
}
