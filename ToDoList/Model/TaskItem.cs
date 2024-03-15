namespace ToDoList.Model;

public class TaskItem
{
    private static int _nextId;
    private DateOnly _expireDate;

    public TaskItem(string title, DateOnly expireDate, bool status, int priority)
    {
        Id = NextVal();
        Title = title;
        _expireDate = expireDate;
        Status = status;
        Priority = priority;
    }

    public int Id { get; set;  }

    public string Title { get; set; }

    public DateOnly ExpireDate
    {
        get => _expireDate;
        set
        {
            if(value >= DateOnly.FromDateTime(DateTime.Today)) 
                _expireDate = value;
        } 
    }

    public bool Status { get; set; }

    public int Priority { get; set; }

    private static int NextVal()
    {
        return ++_nextId;
    }
}