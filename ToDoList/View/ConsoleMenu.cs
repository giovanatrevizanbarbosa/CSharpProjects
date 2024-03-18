using ToDoList.Controller;
using ToDoList.Model;
namespace ToDoList.View;
public class ConsoleMenu
{
    private static TaskController _taskController; 
    
    public static void RunMenu()
    {
        _taskController = TaskController.GetInstance();
        Utils.MsgUpper("============== BEM-VINDO AO SEU TO-DO LIST ==============\n");

        MenuOption option;

        do
        {
            option = Utils.ShowMenu();
            switch (option)
            {   
                case MenuOption.AddTask:
                    TaskItem item = Utils.getTaskItem();
                    _taskController.InsertTask(item);
                    Utils.MsgUpper("Adicionado com sucesso.\n");
                    break;
                case MenuOption.RemoveTask:
                    Console.WriteLine(_taskController.ShowAllTasks());
                    int taskId = int.Parse(Console.ReadLine() ?? string.Empty);
                    if (_taskController.DeleteTask(taskId)) Utils.MsgUpper("Removido com sucesso.\n");
                    else Utils.MsgUpper("Erro ao excluir.");
                    break;
                case MenuOption.UpdateTask:
                    Console.WriteLine(_taskController.ShowAllTasks());
                    taskId = Utils.getTaskId();
                    Utils.MsgUpper("Insira a task atualizada:...: ");
                    item = Utils.getTaskItem();
                    if (_taskController.UpdateTask(taskId, item)) Utils.MsgUpper("Atualizado com sucesso.\n");
                    else Utils.MsgUpper("Erro ao atualizar.");
                    break;
                case MenuOption.MarkAsCompleted:
                    Console.WriteLine(_taskController.ShowAllTasks());
                    taskId = Utils.getTaskId();
                    if (_taskController.ToggleTaskStatus(taskId)) Utils.MsgUpper("Status atualizado com sucesso.\n");
                    else Utils.MsgUpper("Erro ao atualizar.");
                    break;
                case MenuOption.UnmarkAsCompleted:
                    goto case MenuOption.MarkAsCompleted;
                case MenuOption.SeeAlltasks:
                    Console.WriteLine(_taskController.ShowAllTasks());
                    break;
            }

        } while (option != MenuOption.Exit);
    }
}