﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions dbContextOptions)
            :base(dbContextOptions)
        { 
        
        }

        public DbSet<Article> Articles { get; set; }

    }
}
