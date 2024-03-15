using System.Collections.Generic;
using ToDoList.Model;

namespace ToDoList.Controller;

public class TaskController
{
    private IDictionary<int,TaskItem> _tasks;
    private static readonly TaskController Instance = new TaskController();

    private TaskController()
    {
        _tasks = new Dictionary<int, TaskItem>();
    }
    
    public static TaskController GetInstance()
    {
        return Instance;
    } 

    public void InsertTask(TaskItem task)
    {
        _tasks.Add(task.Id, task);
    }

    public bool DeleteTask(int taskId)
    {
        return _tasks.Remove(taskId);
    }

    public bool UpdateTask(int taskId, TaskItem updatedTask)
    {
        if (_tasks.ContainsKey(taskId))
        {
            updatedTask.Id = taskId;
            _tasks[taskId] = updatedTask;
            return true;
        }
        return false;
    }

    public bool ToggleTaskStatus(int taskId)
    {
        if (_tasks.ContainsKey(taskId))
        {
            _tasks[taskId].Status = !_tasks[taskId].Status;
            return true;
        }
        return false;
    }
    
    
}