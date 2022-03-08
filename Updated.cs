using System;


namespace Snakeandladdergame
{
   public class Updated
    {
       public static void Exactposition()
        {

            int position = 0;
            int Noplay = 0;
            int ladder = 1;
            int snake = 2;

            while (position!=100)
            {
                Random random = new Random();
                int number = random.Next(1, 7);
                int condition = random.Next(3);
                Console.WriteLine("The number on Die is :" + number);
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
                Console.WriteLine($"Final Position Of Player is " + position);


            }



           



        }


    }

}


 
   
      
    


    
    



    
      
      
   

       
    

