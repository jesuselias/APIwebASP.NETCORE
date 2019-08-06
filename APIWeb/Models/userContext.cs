﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIWeb.Models
{
    public class userContext : DbContext
    {
        public userContext(DbContextOptions<userContext> options)
          : base(options)
        {
        }

        public DbSet<user> users { get; set; }
    }
}
