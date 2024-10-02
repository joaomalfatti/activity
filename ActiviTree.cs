
namespace activity;
public  class ActiviTree
{
    /*
        Create a program with 2 values of type *Double* already declared that return;
                * the Sum of these two numbers;
                * the subtraction of the two numbers;
                * the multiplication of thw two numbers;
                * The division of thw numbers (it is worth checking if the second number is 0!);
                * the average of the two numbers.
     */
    public void ActivityTree()
    {
        Console.WriteLine("Hello, I'm João, studient tecnology. Welcome Activity Three.");
        Console.WriteLine();

        Console.WriteLine("Enter the first number: ");
        double numberOne = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the secondary number: ");
        double numberTwo = double.Parse(Console.ReadLine());

        double Sum = numberOne + numberTwo;
        double Subtraction = numberOne - numberTwo;
        double Multiplication = numberOne * numberTwo;
        double Average = Sum / 2;

        Console.WriteLine();
        if (numberTwo == 0)
        {
            Console.WriteLine("Error: Number 0 is not allowed.");
        }
        else
        {
            double Division = numberOne / numberTwo;
            Console.WriteLine($"Result Division and : {Division}");
        }
        

        

        Console.WriteLine($"Result Sum and : {Sum}");
        Console.WriteLine($"Result Subtraction and : {Subtraction}");
        Console.WriteLine($"Result Multiplication and : {Multiplication}");
        Console.WriteLine($"Result Average and : {Average}");

    }
}
