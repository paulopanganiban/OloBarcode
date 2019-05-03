using Microsoft.EntityFrameworkCore;
using OloApp.DotnetApi.Models;

namespace OloApp.DotnetApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<value> ValuesOlo { get; set; }
        public DbSet<User> Users { get; set; }
    }
}