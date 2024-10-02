
namespace activity;
public  class ActiviTwo
{
    /*
     *  Create a program that concatenates a first and last name
     *  entered by the user and at the end display the full name.
     *
     */
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
