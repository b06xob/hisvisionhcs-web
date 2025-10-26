using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HisVisionHCS.Web.Migrations
{
    /// <inheritdoc />
    public partial class RemoveStaffFieldsFromCommunityEngagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Remove Staff fields
            migrationBuilder.DropColumn(
                name: "StaffName",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "CommunityEngagements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Add back Staff fields
            migrationBuilder.AddColumn<string>(
                name: "StaffName",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StaffId",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
