using System;


namespace Snakeandladdergame
{
    public class Diceroll
    {
        public static void Player()
        {
            Console.WriteLine("Please enter your name :");
            string input = Console.ReadLine();

            Random random = new Random();
            int number = random.Next(1, 7);

            
           Console.WriteLine("The number appeared is:" +number);
            

            
        }
    }
}
