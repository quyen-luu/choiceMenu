public class Program
{
    public static void choice(int yourNumber)
    {
        switch (yourNumber)
        {
            case 1:
                Console.WriteLine("Draw the traingle");
                Console.WriteLine("******");
                Console.WriteLine("*****");
                Console.WriteLine("****");
                Console.WriteLine("***");
                Console.WriteLine("**");
                Console.WriteLine("*");
                break;
            case 2:
                Console.WriteLine("Draaw the square");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                break;
            case 3:
                Console.WriteLine("Draw the rectangle");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Error.");
                break;
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Draw the triangle");
        Console.WriteLine("2. Draw the square");
        Console.WriteLine("3. Draw the rectangle");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");
        int yourNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        choice(yourNumber);
    }
}
        