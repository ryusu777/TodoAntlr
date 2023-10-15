using Microsoft.EntityFrameworkCore;
using TodoAppCli.CreateTodo;

namespace TodoAppCli.Data;

public class TodoAppContext : DbContext 
{
    public DbSet<Todo> Todos { get; set; }
    public string DbPath { get; }

    public TodoAppContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "todo.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}