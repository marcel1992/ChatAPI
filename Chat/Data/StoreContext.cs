using Chat.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Chat.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<ChatModel> Chats { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
