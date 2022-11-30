using Microsoft.EntityFrameworkCore;

namespace ProjectForInfoDev.Models
{
    public class BloodContext:DbContext
    {
        public BloodContext(DbContextOptions<BloodContext> options): base(options)
        {

        }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<SpecialQuery> Queries { get; set; }
    }
}
