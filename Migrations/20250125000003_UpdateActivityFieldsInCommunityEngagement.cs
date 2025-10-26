using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HisVisionHCS.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateActivityFieldsInCommunityEngagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add SaturdayDate field
            migrationBuilder.AddColumn<DateTime>(
                name: "SaturdayDate",
                table: "CommunityEngagements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            // Add TransportationProvided field
            migrationBuilder.AddColumn<bool>(
                name: "TransportationProvided",
                table: "CommunityEngagements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            // Remove DurationHours field
            migrationBuilder.DropColumn(
                name: "DurationHours",
                table: "CommunityEngagements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove SaturdayDate field
            migrationBuilder.DropColumn(
                name: "SaturdayDate",
                table: "CommunityEngagements");

            // Remove TransportationProvided field
            migrationBuilder.DropColumn(
                name: "TransportationProvided",
                table: "CommunityEngagements");

            // Add back DurationHours field
            migrationBuilder.AddColumn<decimal>(
                name: "DurationHours",
                table: "CommunityEngagements",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
