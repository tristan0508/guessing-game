using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 43;
            int userTry = 0;
            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());
            
            while(guess != secretNumber && userTry < 3){
                Console.WriteLine("guess again");
                Console.WriteLine("");
                userTry++;
                Console.WriteLine($"Tries Left {userTry}/4");
                Console.WriteLine("");
                guess = int.Parse(Console.ReadLine());
            
            }

            if(userTry < 3 || guess == secretNumber){
                Console.WriteLine($"Correct! The secret number is {secretNumber}");
            } else {
                Console.WriteLine("Failure");
            }
        }

    }
}
