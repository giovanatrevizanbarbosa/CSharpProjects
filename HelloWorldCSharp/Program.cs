namespace HelloWorldCSharp;

class Program
{
    static void Main(string[] args)
    {
        HelloWorld helloMessage = new HelloWorld();
        helloMessage.SetHello("Hello World");
        Console.WriteLine(helloMessage.GetHello());
    }
}