using ToDoList.Model;

namespace ToDoList.View;
public class Utils
{
    public static MenuOption ShowMenu()
    {
        Console.WriteLine("========================== MENU =========================");
        Console.WriteLine("1 ADICIONAR TASK");
        Console.WriteLine("2 REMOVER TASK");
        Console.WriteLine("3 ATUALIZAR TASK");
        Console.WriteLine("4 MARCAR TASK COMO FEITA");
		Console.WriteLine("5 DESMARCAR TASK COMO FEITA");
        Console.WriteLine("6 VER TODAS AS TASKS");
        Console.WriteLine("0 SAIR");
        
        int input = int.Parse(Console.ReadLine() ?? string.Empty);

        return (MenuOption)input;
    }

    public static void Line()
    {
        Console.WriteLine("=========================================================");
    }

    public static void MsgUpper(string message)
    {
        Console.Write(message.ToUpper());
    }

    public static DateOnly StringToDate(string date)
    {
        return DateOnly.Parse(date);
    }

    public static TaskItem getTaskItem()
    {
        MsgUpper("Título:...: ");
        string title = Console.ReadLine() ?? string.Empty;
        MsgUpper("Data de término:...: ");
        DateOnly date = Utils.StringToDate(Console.ReadLine() ?? string.Empty);
        MsgUpper("Prioridade:...: \n");
        MsgUpper("1 - Alta\n2 - Média\n3- Baixa\n");
        int priority = int.Parse(Console.ReadLine() ?? string.Empty);
        
        return new TaskItem(title, date, false, priority);
    }

    public static int getTaskId()
    {
        Line();
        MsgUpper("Escolha a task (NÚMERO):...: ");
        return int.Parse(Console.ReadLine() ?? string.Empty);
    }
}