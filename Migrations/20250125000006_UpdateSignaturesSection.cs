using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HisVisionHCS.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSignaturesSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add StaffName field
            migrationBuilder.AddColumn<string>(
                name: "StaffName",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            // Remove supervisor and additional fields
            migrationBuilder.DropColumn(
                name: "SupervisorName",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "SupervisorSignature",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "SupervisorDate",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "SupervisorReview",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "AdditionalComments",
                table: "CommunityEngagements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove StaffName field
            migrationBuilder.DropColumn(
                name: "StaffName",
                table: "CommunityEngagements");

            // Add back supervisor and additional fields
            migrationBuilder.AddColumn<string>(
                name: "SupervisorName",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisorSignature",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SupervisorDate",
                table: "CommunityEngagements",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SupervisorReview",
                table: "CommunityEngagements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalComments",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
