using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        { 
            game();
        }


        public static void game()
        {
            Console.WriteLine("Welcome to guesser game");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rules: Guess the random number between 1-10, You get 3 chances.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;


          
            
            GG();
            Console.ForegroundColor = ConsoleColor.Blue;
            playagain();
           
            
            

           
        }

        public static void playagain()
        {
            Console.WriteLine("Would you like to play again: Y or N");
            String ans = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (ans == "Y")
            {
                GG();
                Console.ForegroundColor = ConsoleColor.Blue;
                playagain();
            }

            if (ans == "N")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                return;
            }
            else

            Console.WriteLine("Please enter a valid choice");
            playagain();


        }

        //Used for the player guessing each number
        static int playerguess()
        {
            Console.WriteLine();
            Console.WriteLine("Take a guess: ");
            string playerGuess = Console.ReadLine();

            int playerNum = Convert.ToInt32(playerGuess);

            return playerNum;
        }

        //Checks if the number guessed matches the random number
        static bool isItNum(int w, int rand)
        {
            if(w == rand)
            {
               return true;
            }

            return false;
        }

        //Takes player input and random number to determine game
        static void GG(){

            Random rand = new Random();
            int num = rand.Next(1, 10);
            bool ans;
            int play;

            for(int x = 0; x < 3; x++)
            {
                play = playerguess();
                ans = isItNum(play, num);

                if (ans == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CONGRATS YOU WIN!!!");
                    Console.WriteLine();
                    return;
                   
                }
            }
    
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You Lose");
            Console.WriteLine();
        }
    }
}
