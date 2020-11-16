using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 43;
            int userTry = 1;
            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());
            
            while(guess != secretNumber && userTry < 4){
                Console.WriteLine("guess again");
                guess = int.Parse(Console.ReadLine());
                userTry++;
            }

            if(userTry == 4){
                Console.WriteLine("Failure!");
            } else {
                Console.WriteLine("Success!");
            }
        }

    }
}
