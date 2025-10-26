using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HisVisionHCS.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCommunityEngagementFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the Date column
            migrationBuilder.DropColumn(
                name: "Date",
                table: "CommunityEngagements");

            // Rename MemberId to MemberPhoneNumber
            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "CommunityEngagements",
                newName: "MemberPhoneNumber");

            // Add new Caregiver fields
            migrationBuilder.AddColumn<string>(
                name: "CaregiverName",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CaregiverPhoneNumber",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove Caregiver fields
            migrationBuilder.DropColumn(
                name: "CaregiverName",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "CaregiverPhoneNumber",
                table: "CommunityEngagements");

            // Rename MemberPhoneNumber back to MemberId
            migrationBuilder.RenameColumn(
                name: "MemberPhoneNumber",
                table: "CommunityEngagements",
                newName: "MemberId");

            // Add back Date column
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "CommunityEngagements",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }
    }
}
