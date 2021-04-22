using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Migrations
{
    [DbContext(typeof(ArticleContext))]
    [Migration("Migration3_202104221603")]
    public class Migration3_202104222136 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //修改欄位的長度為300
            //                                   欄位名稱  表
            migrationBuilder.AlterColumn<string>("Title", "Article",  maxLength: 300, nullable: false);
            migrationBuilder.AlterColumn<string>("Kind", "Article", maxLength: 50, nullable: false);
            migrationBuilder.AlterColumn<string>("Content", "Article", maxLength: 1000, nullable: false);
            migrationBuilder.AlterColumn<string>("Author", "Article", maxLength: 20, nullable: false);

            //新增欄位
            //新增欄位到已經存在的表必須先讓欄位允許為空，再去修改為不為null，不然會報錯
            migrationBuilder.AddColumn<DateTime>("CreateTime", "Article", nullable:true);

            //必須新增資料給新的欄位
            migrationBuilder.Sql(@" UPDATE Article
                                    SET CreateTime = GETDATE()
                                  ");

            //這邊才能將新欄位設為 [NOT NULL]
            migrationBuilder.AlterColumn<DateTime>("CreateTime", "Article", nullable: false);
        }
    }
}
