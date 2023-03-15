using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitApp.Models;

namespace RecruitApp.Data
{
    public class RecruitAppContext : DbContext
    {
        public RecruitAppContext (DbContextOptions<RecruitAppContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitApp.Models.Movie> Movie { get; set; } = default!;
    }
}
