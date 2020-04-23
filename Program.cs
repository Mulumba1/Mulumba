using Microsoft.VisualBasic;
using System;

namespace HardGames
{
    class Program
    {
               static void Main(string[] args)
        {
                                        
            Console.WriteLine("Welcome to HardGames!: " +
            "\n\nInstruction: \nTry to guess the number between the selected difficulty range." +
            "\nIf you guess the right number you win!");
            
            Console.WriteLine("dificulty: \n[1] (1-10) Easy \n[2] (1-20)  Medium \n[3] (1-50) Hard");
            Console.WriteLine("Press numbers from 1-3 to select level: "); 

            while (true)
            {
                int randomNum = 60;
                int count =1;
                while (true)
                {
                   Console.Write("Enter a number between 1 and 60 (0 to quite):");
                   int input = Convert.ToInt32(Console.ReadLine());
                   if (input == 0)
                   return;
                   else if (input < randomNum)
                   {
                       Console.WriteLine("wrong, Try again.");
                       ++ count;
                       continue;
                   }
                    else if (input > randomNum)
                    {
                     Console.WriteLine("Too High, Try again.");
                    ++count;
                    continue;
                    }
                    else 
                    {
                        Console.WriteLine("Congratulation! You got it, the number was {0}!" , randomNum);
                        Console.WriteLine("it took you {0}{1}. \n", count, count ==1 ? "time":"times");
                        break;
                    }
                }
            }
        
            
                      
                  
              
            


             


        }
    }
}
