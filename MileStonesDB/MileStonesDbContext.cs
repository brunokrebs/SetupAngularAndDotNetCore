using Microsoft.EntityFrameworkCore;
using MileStones.Models;

namespace MileStones.MileStonesDB
{
    public class MileStonesDbContext : DbContext
    {
        public MileStonesDbContext(DbContextOptions<MileStonesDbContext> options) 
            : base(options){}

        public DbSet<Student> Students { get; set; }
    }
}