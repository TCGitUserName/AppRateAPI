using Microsoft.EntityFrameworkCore;

namespace AppRateAPI.Models
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) :base(options)
        {

        }

        public DbSet<Command> RateList { get; set;}
    }
}