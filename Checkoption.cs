using System;

namespace Snakeandladdergame
{
    public class Checkoption
    {
        public static void Conditioncase()
        {
            Console.WriteLine("Please enter your name :");
            string input = Console.ReadLine();

            Random random = new Random();
            int number = random.Next(1, 7);
            int condition = random.Next(3);

            Console.WriteLine("Number on Die is:" + number);
            int position = 0;
            int Noplay = 0;
            int Ladder = 1;
            int snake = 2;

            switch(condition)
            {
                case 0:
                    Console.WriteLine("No Play");
                    Console.WriteLine("Your position remains same.");
                    break;
                    case 1:
                    position = position + number;
                    Console.WriteLine("You got a ladder");
                    Console.WriteLine("Now your position is :" + position);
                    break;
                case 2:
                    position = position - number;
                    Console.WriteLine("You are on snake");
                    Console.WriteLine("Now your position is :" + position);
                    break;




            }


        }
          

    }
            
    



}
   
    
   

