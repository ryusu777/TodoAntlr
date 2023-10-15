using System.Data.Common;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using TodoAppCli.Data;
using TodoAppCli.Service;
using static TodoParser;

namespace TodoAppCli.CreateTodo;

public class TodoHandler : TodoBaseVisitor<object>
{
    private TodoService service = new TodoService();
    public override object VisitCreate(TodoParser.CreateContext context)
    {
        DescriptionContext desc = context.description();
        TimeContext time = context.time();

        if (desc == null || time == null)
            return null;

        Todo item = new Todo("", "");
        item.Description = desc.GetText().Trim('"');
        item.FinishTarget = time.GetText();
        item.Id = null;

        service.SaveTodo(item);

        return item;
    }
    public override object VisitShow(ShowContext context)
    {
        ICollection<Todo> items = service.GetTodos();
        ShowTodos(items);

        return items;
    }
    public override object VisitFinish([NotNull] FinishContext context)
    {
        IdContext id = context.id();

        try 
        {
            Todo todo = service.CompleteTodo(int.Parse(id.GetText()));
            Console.WriteLine("Successfully completed " + todo.ToString());
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }
    public override object VisitDelete([NotNull] DeleteContext context) 
    {
        IdContext id = context.id();

        try 
        {
            Todo todo = service.DeleteTodo(int.Parse(id.GetText()));
            Console.WriteLine("Successfully deleted " + todo.ToString());
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine(ex.Message);
        }
        return null;
    }
    public void ShowTodos(ICollection<Todo> items)
    {
        Console.WriteLine("You have these works");
        foreach (Todo item in items) 
        {
            Console.WriteLine(item.ToString());
        }

        if (items.Count == 0) 
        {
            Console.WriteLine("You have no works");
        }
    }
    public static void Process(string input) 
    {
        AntlrInputStream inputStream = new AntlrInputStream(input);
        TodoLexer lexer = new TodoLexer(inputStream);
        CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
        TodoParser parser = new TodoParser(commonTokenStream);
        CompileUnitContext compile = parser.compileUnit();
        TodoHandler visitor = new TodoHandler();
        visitor.Visit(compile);
    }
}