
namespace activity;
public  class ActiviTwo
{
    public void ActivityTwo()
    {
        //Message is User
        Console.WriteLine("What primary your name?");
        string nameUser = Console.ReadLine();

        Console.WriteLine("Whats secondary your name?");
        string surnameUser = Console.ReadLine();

        string nameComplet = nameUser + " " + surnameUser;

        Console.WriteLine(nameComplet);
    }
}
