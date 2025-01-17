﻿using APIGateway.Models;
using Microsoft.EntityFrameworkCore;

namespace APIGateway.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
