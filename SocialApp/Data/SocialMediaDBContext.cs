using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialApp.Models;

    public class SocialMediaDBContext : DbContext
    {
        public SocialMediaDBContext (DbContextOptions<SocialMediaDBContext> options)
            : base(options)
        {
        }

        public DbSet<SocialApp.Models.Post> Post { get; set; } = default!;

public DbSet<SocialApp.Models.User> User { get; set; } = default!;
    }
