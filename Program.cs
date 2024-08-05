using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_While_and_Do_Loops
{
    internal class Program
    {
        static void Main(string[] args)
            //Intro statement and asking for user input
        {
            Console.WriteLine("How many pounds does the average adult African Bush Elephant weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = weight == 13000;
            //The DO swtich
            do
            {   //The loop
                switch (weight)
                {
                    case 13000:
                        Console.WriteLine("You guessed 13,000 lbs. You are correct!!!");
                        weight = Convert.ToInt32(Console.ReadLine());
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess again.");
                        weight = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (isGuessed == false);
            
            Console.Read();
        }
        
    }
}
