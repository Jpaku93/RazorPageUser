using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageUser.Models;

namespace RazorPageUser.Data
{
    public class RazorPageUserContext : DbContext
    {
        public RazorPageUserContext (DbContextOptions<RazorPageUserContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageUser.Models.User> User { get; set; }
    }
}
