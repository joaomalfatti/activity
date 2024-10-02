namespace activity
{
    public class ActiviFour
    {
        public void RunActivityFour() // Nome do método alterado
        {
            /*
                4 - Create a program in which the user types
                one or more word and the number of characters the
                entered word has is displayed.
            */

            // Welcome Message.
            Console.WriteLine("Hello, I'm João, student of Technology. Learning C# ");
            Console.WriteLine();

            // Prompts the user to enter one or more words.
            Console.WriteLine("Enter one or more words: ");
            string inputUser = Console.ReadLine();

            int characterCounter = 0;

            // Counts characters without sapces.
            foreach (char c in inputUser)
            {
                if (c != ' ')
                {
                    characterCounter++;
                }
            }

            // Displays the number of characters(
            Console.WriteLine($"The number of characters (not counting spaces) is: {characterCounter}");
        }
    }
}
