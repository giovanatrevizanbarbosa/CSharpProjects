using ToDoList.Controller;
using ToDoList.View;
namespace ToDoList;
public class ConsoleMenu
{
    private TaskController _taskController; 
    
    public ConsoleMenu()
    {
        _taskController = TaskController.GetInstance();
    }
    public static void RunMenu()
    {
        Console.WriteLine("============== BEM-VINDO AO SEU TO-DO LIST ==============");

        MenuOption option;

        do
        {
            option = Utils.ShowMenu();
            switch (option)
            {   
                case MenuOption.AddTask:
                    Utils.ShowMessage("Título:...: ");
                    string title = Console.ReadLine() ?? string.Empty;
                    Utils.ShowMessage("Data de término:...: ");
                    DateOnly date = Utils.StringToDate(Console.ReadLine() ?? string.Empty);
                    Utils.ShowMessage("Prioridade:...: ");
                    Utils.ShowMessage("1 - Alta\n2 - Média\n3- Baixa ");
                    int priority = int.Parse(Console.ReadLine() ?? string.Empty);
                    break;
                case MenuOption.RemoveTask:
                    break;
                case MenuOption.UpdateTask:
                    break;
                case MenuOption.MarkAsCompleted:
                    break;
                case MenuOption.UnmarkAsCompleted:
                    break;
            }

        } while (option != MenuOption.Exit);
    }
}