using System.Collections.Generic;
using ToDoList.Model;
using ToDoList.View;

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

    public string ShowAllTasks()
    {
        string msg = "";
        foreach(var taskItem in _tasks.Values)
        {
            msg += $"\n========================== TASK {taskItem.Id} =========================\n";
            msg += "TÍTULO.......: " + taskItem.Title
                 + "\nDATA FINAL...: " + taskItem.ExpireDate;
            switch (taskItem.Priority)
            {
                case 1: 
                    msg += "\nPRIORIDADE...: ALTA";
                    break;
                case 2: 
                    msg += "\nPRIORIDADE...: MÉDIA";
                    break;
                case 3: 
                    msg += "\nPRIORIDADE...: BAIXA";
                    break;
            }
            if (taskItem.Status)
            {
                msg += "\nSTATUS.......: COMPLETA";
            }
            else
            {
                msg += "\nSTATUS.......: A FAZER";
            }
        }

        return msg;
    }
}