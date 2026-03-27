using Microsoft.EntityFrameworkCore;
using LoveMatchDemo.Models;

namespace LoveMatchDemo.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        public DbSet<Game> Games { get; set; }

    }
}
