using System.Data.Common;
using System.Security.Cryptography;
using TodoAppCli.CreateTodo;
using TodoAppCli.Data;

namespace TodoAppCli.Service;

public class TodoService : IDisposable
{
    private readonly TodoAppContext _db;

    public TodoService()
    {
        _db = new TodoAppContext();
    }
    public ICollection<Todo> GetTodos() 
    {
        using TodoAppContext _db = new TodoAppContext();
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        return _db.Todos.Where(e => 
            e.Date == today)
            .ToList();
    }

    public void SaveTodo(Todo item) 
    {
        _db.Add(item);
        _db.SaveChanges();
    }
    public Todo CompleteTodo(int id) 
    {
        Todo? todo = _db.Todos.SingleOrDefault(e => e.Id == id);

        if (todo == null)
            throw new InvalidDataException("The todo is not found");

        todo.IsFinished = true;

        _db.SaveChanges();

        return todo;
    }
    public Todo DeleteTodo(int id) 
    {
        Todo? todo = _db.Todos.SingleOrDefault(e => e.Id == id);

        if (todo == null)
            throw new InvalidDataException("The todo is not found");

        _db.Remove(todo);
        _db.SaveChanges();

        return todo;
    }
    public void Dispose()
    {
        _db.Dispose();
    }
}