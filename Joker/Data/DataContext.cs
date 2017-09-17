using Joker.Objects;
using Microsoft.EntityFrameworkCore;

namespace Joker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) :
            base(options)
        {
        }

        public DbSet<Joke> Jokes { get; set; }
    }
}