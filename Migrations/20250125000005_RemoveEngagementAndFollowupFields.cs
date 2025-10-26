using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HisVisionHCS.Web.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEngagementAndFollowupFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Remove Engagement Details fields
            migrationBuilder.DropColumn(
                name: "MemberResponse",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "Observations",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "GoalsAchieved",
                table: "CommunityEngagements");

            // Remove Follow-up fields
            migrationBuilder.DropColumn(
                name: "FollowUpRequired",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "FollowUpNotes",
                table: "CommunityEngagements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Add back Engagement Details fields
            migrationBuilder.AddColumn<string>(
                name: "MemberResponse",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observations",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoalsAchieved",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            // Add back Follow-up fields
            migrationBuilder.AddColumn<bool>(
                name: "FollowUpRequired",
                table: "CommunityEngagements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FollowUpNotes",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
