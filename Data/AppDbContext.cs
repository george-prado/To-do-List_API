using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data
{
	public class AppDbContext : DbContext
	{
        public DbSet<TodoModel> Todos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
	}
}
