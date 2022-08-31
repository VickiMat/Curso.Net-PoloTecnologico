
internal class Program
{
    private static void Main(string[] args)
    {
        string userAnswer = "Y";

        while (userAnswer == "Y")
        {
            Console.Clear();

            Console.WriteLine("Please, insert your name:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}!");

            Console.WriteLine("Do you want to continue? Y/N");
            userAnswer = Console.ReadLine().ToUpper();
        }
        if (userAnswer == "N") Console.WriteLine("Program completed successfully");
        else Console.WriteLine("Option invalid");
    }
}