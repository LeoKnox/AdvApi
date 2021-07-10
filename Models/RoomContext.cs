using Microsoft.EntityFrameworkCore;

namespace RoomApi.Models
{
    public class RoomContext : DbContext
    {
        public RoomContext(DbContextOptions<RoomContext> options) : base(options)
        {
        }

        public DbSet<RoomItem> RoomItems { get; set; }
    }
}