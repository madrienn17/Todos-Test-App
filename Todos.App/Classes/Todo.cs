namespace Todos.App.Classes;

public class Todo
{
    public int Id { get; set; }
    public string Description { get; set; } = String.Empty;
    public bool Completed { get; set; } = false;
}