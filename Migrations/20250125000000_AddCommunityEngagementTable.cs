using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HisVisionHCS.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddCommunityEngagementTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommunityEngagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunityActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Participants = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberResponse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoalsAchieved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FollowUpRequired = table.Column<bool>(type: "bit", nullable: false),
                    FollowUpNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSigned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SupervisorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SupervisorReview = table.Column<bool>(type: "bit", nullable: false),
                    AdditionalComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityEngagements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommunityEngagements");
        }
    }
}
