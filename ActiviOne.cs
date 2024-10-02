
namespace activity;
public class ActiviOne
{
    /*
        Create a program where the user has to enter a name and a personalized
    welcome message with his name is displayed.
     
     */
    public void ActivityOne()
    {
        //Message is Welcome
        Console.WriteLine("Hello, I'm João, studient de tecnology.");
        Console.WriteLine("What your name?");

        //Display the message welcome.
        string nameUser = Console.ReadLine();

        //Result
        Console.WriteLine($"Hello, {nameUser}! Welcome.");
    }
}
