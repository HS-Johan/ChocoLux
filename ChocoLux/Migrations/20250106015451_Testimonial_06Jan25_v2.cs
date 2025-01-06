﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChocoLux.Migrations
{
    /// <inheritdoc />
    public partial class Testimonial_06Jan25_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestimonialIsActive",
                table: "Testimonial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TestimonialIsActive",
                table: "Testimonial",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
