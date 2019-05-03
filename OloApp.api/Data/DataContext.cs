using Microsoft.EntityFrameworkCore;
using OloApp.api.Models;

namespace OloApp.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<value> ValuesOlo { get; set; }
    }
}