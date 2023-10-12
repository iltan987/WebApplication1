using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using WebApplication1.Models;

namespace WebApplication1.Contexts
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            MySqlConnectionStringBuilder mscb = new()
            {
                Server = "127.0.0.1",
                Port = 3306,
                UserID = "root",
                Database = "Users"
            };
            optionsBuilder.UseMySQL(mscb.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}