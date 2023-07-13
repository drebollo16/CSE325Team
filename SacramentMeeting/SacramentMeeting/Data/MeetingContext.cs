using Microsoft.EntityFrameworkCore;
using SacramentMeeting.Models;
using SacramentMeeting.Data; 

namespace SacramentMeeting.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options) { }

        public DbSet<MeetingPlanner>MeetingPlanners{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeetingPlanner>().ToTable("Meeting");
        }

    }
}
