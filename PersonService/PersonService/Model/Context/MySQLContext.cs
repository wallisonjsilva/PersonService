
using Microsoft.EntityFrameworkCore;

namespace PersonService.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public virtual DbSet<Person> Persons { get; set; }
    }
}