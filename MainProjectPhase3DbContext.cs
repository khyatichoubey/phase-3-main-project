using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MainProjectPhase3.Models;

namespace MainProjectPhase3.Data
{
    public class MainProjectPhase3DbContext : DbContext
    {
        public MainProjectPhase3DbContext (DbContextOptions<MainProjectPhase3DbContext> options)
            : base(options)
        {
        }

        public DbSet<MainProjectPhase3.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
