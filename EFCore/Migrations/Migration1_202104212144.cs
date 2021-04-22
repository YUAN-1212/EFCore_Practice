using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    [DbContext(typeof(ArticleContext))]
    [Migration("Migration_202104212144")]
    public class Migration1_202104212144 : Migration
    {
        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns:cb => new
                { 
                    Id =cb.Column<int>(nullable: false)
                            .Annotation("SqlServer: Identity", "1, 1"),
                    Title = cb.Column<string>(nullable: false),
                    Kind = cb.Column<string>(nullable: false),
                    Content = cb.Column<string>(nullable: false),
                    Author = cb.Column<string>(nullable: false),
                },
                constraints: c => c.PrimaryKey("Pk_Article_Key", x=>x.Id)
                );;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Article");
        }
    }
}
