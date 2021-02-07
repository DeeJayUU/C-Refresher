using System;

namespace LoopExercise1
{
       
        class Program
        {
            /*
             * 
             *  Write a console-based application that prompts a user for an
                hourly pay rate. While the user enters values less than £5.65
                or greater than £49.99, continue to prompt the user. Before
                the program ends, display the valid pay rate
             * 
             * */
            static void Main(string[] args)
            {
                double payRate;
                do
                {
                    Console.WriteLine("Please enter a valid payrate");
                    payRate = double.Parse(Console.ReadLine());
                } while (payRate < 5.65 || payRate > 49.99);

                Console.WriteLine("The valid payrate that you entered is {0}", payRate);
            }
    }
}
