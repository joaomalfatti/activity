
namespace activity;
public class ActiviSix
{
    public void ActivitySix()
        /*
         * 6 - Create a program that prompts the user to display the current date in different formats:
         * * Full format (day fo the week, day of the month, month, year, hour, minutes, seconds).
         * * Just the date in the format "01/03/2024".
         * * Jus the time in 24-hour format.
         * * The date with the month in full.
         */

    {
        //Message Welcome
        Console.WriteLine("Hello, I'm João, student of Technology. Learning C# ");
        Console.WriteLine();

        // Getting the date and current time
        DateTime now = DateTime.Now;

        //View menu options.
        Console.WriteLine("Select the data format you want to see:");
        Console.WriteLine();

        Console.WriteLine("1. Full format (day of the week, day of the month, month, year, hour, minutes, seconds)");
        Console.WriteLine("2. Date only (dd/MM/yyyy) ");
        Console.WriteLine("3. Time only (HH:mm) ");
        Console.WriteLine("4. Date with month in full ");
        Console.Write("Choose an option (1-4) ");
        Console.WriteLine();

        Console.WriteLine();

        string option = Console.ReadLine();

        Console.WriteLine();
        //Displaying result based on user choice
        switch (option)
        {
            case "1":
                Console.WriteLine("Date complety: " + now.ToString("dddd, dd 'of' MMMM 'of' yyyy HH:mm:ss)"));
                break;
            case "2":
                Console.WriteLine("Date: " + now.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine("Hours: " + now.ToString("HH:mm"));
                break;
            case "4":
                Console.WriteLine("Date with month in full: " + now.ToString("dd 'of' MMMM 'of' yyyy"));
                break;
            default:
                Console.WriteLine("Invalid Option. Please choose between 1 and 4");
                break;
        }
    }
}
