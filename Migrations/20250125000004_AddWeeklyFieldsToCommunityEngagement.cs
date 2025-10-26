using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HisVisionHCS.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddWeeklyFieldsToCommunityEngagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add all day-specific fields
            var days = new[] { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            
            foreach (var day in days)
            {
                // Date field
                migrationBuilder.AddColumn<DateTime>(
                    name: $"{day}Date",
                    table: "CommunityEngagements",
                    type: "datetime2",
                    nullable: false,
                    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

                // Activity field
                migrationBuilder.AddColumn<string>(
                    name: $"{day}Activity",
                    table: "CommunityEngagements",
                    type: "nvarchar(max)",
                    nullable: true);

                // Location field
                migrationBuilder.AddColumn<string>(
                    name: $"{day}Location",
                    table: "CommunityEngagements",
                    type: "nvarchar(max)",
                    nullable: true);

                // Transportation field
                migrationBuilder.AddColumn<bool>(
                    name: $"{day}TransportationProvided",
                    table: "CommunityEngagements",
                    type: "bit",
                    nullable: false,
                    defaultValue: false);

                // Staff Support field
                migrationBuilder.AddColumn<string>(
                    name: $"{day}StaffSupport",
                    table: "CommunityEngagements",
                    type: "nvarchar(max)",
                    nullable: true);

                // Outcome field
                migrationBuilder.AddColumn<string>(
                    name: $"{day}Outcome",
                    table: "CommunityEngagements",
                    type: "nvarchar(max)",
                    nullable: true);
            }

            // Remove old single-day fields
            migrationBuilder.DropColumn(
                name: "CommunityActivity",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "TransportationProvided",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "Participants",
                table: "CommunityEngagements");

            migrationBuilder.DropColumn(
                name: "ActivityDescription",
                table: "CommunityEngagements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Add back old single-day fields
            migrationBuilder.AddColumn<string>(
                name: "ActivityDescription",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommunityActivity",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Participants",
                table: "CommunityEngagements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TransportationProvided",
                table: "CommunityEngagements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            // Remove all day-specific fields
            var days = new[] { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            
            foreach (var day in days)
            {
                migrationBuilder.DropColumn(
                    name: $"{day}Date",
                    table: "CommunityEngagements");

                migrationBuilder.DropColumn(
                    name: $"{day}Activity",
                    table: "CommunityEngagements");

                migrationBuilder.DropColumn(
                    name: $"{day}Location",
                    table: "CommunityEngagements");

                migrationBuilder.DropColumn(
                    name: $"{day}TransportationProvided",
                    table: "CommunityEngagements");

                migrationBuilder.DropColumn(
                    name: $"{day}StaffSupport",
                    table: "CommunityEngagements");

                migrationBuilder.DropColumn(
                    name: $"{day}Outcome",
                    table: "CommunityEngagements");
            }
        }
    }
}
