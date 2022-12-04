using System.Data.Entity;
using WebApplication.Models;

namespace WebApplication.Db
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}