using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace EFCore.Migrations
{
    [DbContext(typeof(ArticleContext))]
    [Migration("Migration2_202104221603")]
    public class Migration2_202104221603 : Migration
    {
        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            // INSERT DATA TO Article 
            migrationBuilder.Sql(@"INSERT INTO Article VALUES ('迎風面3縣市大雨特報 西半部還是晴到多雲天氣',
                                        '氣象', '〔即時新聞／綜合報導〕中央氣象局今天（22日）特報連發，颱風消息方面，第2號颱風「舒力基」清晨2時位於鵝鑾鼻東南方510公里的海面上，
                                        今日位於東南方遠海，未來將轉向東北東逐漸遠離，直接影響台灣機率較低。',
                                        'ABC'
                                    )");
        }
    }
}
