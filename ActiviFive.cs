
namespace activity
{
    public class ActiviFive
    {

        /*
         * 5 - Create a program in which the user needs to enter a vehicle's license plate and the program checks whether
         * the plate is valid, following the Brazilian stard valid until 2018:
         *  * The plate must have 7 alphanumeric characters;
         *  * The first three characters are letters ( upper or lower case).
         *  * The las four character are numbers;
         *  
         *  at the end, th eprogram should display *True* if the plate is valid and *False* otherwise.
         */
        public void ActivityFive()
        {
            // Welcome Message.
            Console.WriteLine("Hello, I'm João, student of Technology. Learning C# ");
            Console.WriteLine();

            Console.WriteLine("Enter the vehicle license plate:");
            string plate = Console.ReadLine();

            bool plateValid = false;

            if (plate.Length == 7)
            {
                // Check if the first three are letters
                bool validLetters = char.IsLetter(plate[0]) && char.IsLetter(plate[1]) && char.IsLetter(plate[2]);

                // Check if the las four are numbers
                bool validNumbers = char.IsDigit(plate[3]) && char.IsDigit(plate[4]) && char.IsDigit(plate[5]) && char.IsDigit(plate[6]);

                if (validLetters && validNumbers)
                {
                    plateValid = true;
                }
            }

            if (plateValid)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
    
}
