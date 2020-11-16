using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 101);
            int difficulty = 0;
            int userTry = 0;

            while (difficulty == 0)
            {
                Console.WriteLine("Select a difficulty");
                Console.WriteLine("1.) Easy - 8 tries");
                Console.WriteLine("2.) Medium - 6 tries");
                Console.WriteLine("3.) Hard - 4 tries");

                difficulty = int.Parse(Console.ReadLine());
                 switch (difficulty)
            {
                case 1:
                    userTry = 8;
                    break;
                case 2:
                    userTry = 6;
                    break;
                case 3: 
                    userTry = 4;
                    break;
                default:
                    userTry = 8;
                    break;
            }
   
            }
            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());
            
            while(guess != secretNumber && userTry != 1){

                Console.WriteLine($"Incorrect.");
                if(guess < secretNumber)
                {
                    Console.WriteLine("Guess is too low!");
                }
                else
                {
                    Console.WriteLine("Guess is too high!");
                }
                
                Console.WriteLine("guess again");
                Console.WriteLine("");
                userTry--;
                Console.WriteLine($"Tries Left {userTry}");
                Console.WriteLine("");
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            
            }

            if(userTry != 1 || guess == secretNumber){
                Console.WriteLine($"Correct! The secret number is {secretNumber}");
            } else {
                userTry--;
                Console.WriteLine("Better Luck Next time!");
            }
        }

    }
}
