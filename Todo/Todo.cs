using System.ComponentModel.DataAnnotations;

namespace TodoAppCli.CreateTodo;

public class Todo 
{
    [Key]
    public int? Id { get; set; }
    public string Description { get; set; }
    public string FinishTarget { get; set; }
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public bool IsFinished { get; set; } = false;

    public override string ToString()
    {
        return string.Format("#{0} '{1}': {2}{3}", Id, Description, FinishTarget, IsFinished ? ", DONE" : "");
    }
    public Todo(string description, string finishTarget)
    {
        Description = description;
        FinishTarget = finishTarget;
    }
}