using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeandladdergame
{
    public class CountdDiceRolls
    {
        public static void Dice()
        {
            int position = 0;
            int Noplay = 0;
            int ladder = 1;
            int snake = 2;
            int diecount = 0;

            while (position < 100)
            {
                Random random = new Random();
                int number = random.Next(1, 7);
                diecount++;
                int condition = random.Next(3);

                switch (condition)
                {
                    case 0:
                        Console.WriteLine("No Play and position is " + position);
                        break;
                    case 1:
                        position = position + number;
                        Console.WriteLine("You got a Ladder and position is " + number);
                        break;
                    case2:
                        position = position - number;
                        Console.WriteLine("You are on Snake and position is " + number);
                }
                if (position < 0)
                {
                    position = 0;
                }
                else if (position > 100)


                {
                    position -= number;
                    Console.WriteLine("position" + position);
                }
                Console.WriteLine($"Position Of Player After Die Roll is {position}");

            }
            Console.WriteLine("Total Number Of Times Die Rolled To Win The Game Is " +diecount);
        }


    }
    
}
