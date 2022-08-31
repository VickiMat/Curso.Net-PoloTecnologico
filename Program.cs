namespace Clase06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GUESS A NUMBER! You have 10 attemps to acert the correct number");
            int secretNumber = new Random(DateTime.Now.Millisecond).Next(1, 21);
            int attempts = 10;

            for (int i = 0; i < 10; i++)
			{
                Console.WriteLine("Please, enter one number between 1-20 to see if you guess the secret number ;)");
                int guessNumber = Int32.Parse(Console.ReadLine());
                    if (guessNumber > secretNumber)
                    {
                    Console.WriteLine("The number is too big!");
                    attempts--;
                    }
                    else if (guessNumber < secretNumber && attempts>0)
                    {
                    Console.WriteLine("The number is too low!");
                    attempts--;
                    }
                    if (guessNumber == secretNumber)
                    {
                        Console.WriteLine($"Congratulations! You have guessed the secret number! It was {secretNumber}");
                        Console.WriteLine($"You did it in {11-attempts} tries!!!");
                    break;
                    }
			}
            if(attempts == 0)
            {
                Console.WriteLine("You don´t have more attemps available");
                Console.WriteLine("Press a key to close the program");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Press a key to close the program");
                Console.ReadKey();
            }  
        }
    }
}