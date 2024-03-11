namespace HelloWorldCSharp;

public class HelloWorld
{
    private string hello = "";

    public void SetHello(string message)
    {
        this.hello = message;
    }

    public string GetHello()
    {
        return hello;
    }
}