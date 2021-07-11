using Microsoft.EntityFrameworkCore;

namespace AdvApi.Models
{
    public class RoomContext : DbContext
    {
        public RoomContext(DbContextOptions<RoomContext> options) : base(options)
        {
        }

        public DbSet<Room> RoomItems { get; set; }
    }
}