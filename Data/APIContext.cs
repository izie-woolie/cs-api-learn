using C_Learn.Models;
using Microsoft.EntityFrameworkCore;

namespace C_Learn.Data
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
