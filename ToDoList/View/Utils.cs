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
        Console.WriteLine("0 SAIR");
        
        int input = int.Parse(Console.ReadLine() ?? string.Empty);

        return (MenuOption)input;
    }

    public static void ShowMessage(string message)
    {
        Console.WriteLine("===================================================");
        Console.WriteLine(message.ToUpper());
        Console.WriteLine("===================================================");
    }

    public static DateOnly StringToDate(string date)
    {
        return DateOnly.Parse(date);
    }
}