using FIRSTREP.API.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace FIRSTREP.API.Data
{
    public class FIRSTREPDbContext:DbContext
    {
        public FIRSTREPDbContext(DbContextOptions<FIRSTREPDbContext>options): base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
