
using System;

namespace Loop_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer between 0 and 20 to execute a loop: ");

            try
            {
                int input = int.Parse(Console.ReadLine());

                if ((input >= 0) && (input <= 5))
                {
                    Console.WriteLine("Executing a For Loop");
                    Console.WriteLine("The For loop will iterate " + input.ToString() + " times");

                    for (int i = 0; i <= input; i++) // i = i + i = i++
                    {
                        Console.WriteLine("The value of the variable i is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }

                else if ((input > 5) && (input <= 15))
                {
                    Console.WriteLine("Executing a While Loop");
                    Console.WriteLine("The While loop will iterate " + input.ToString() + " times");

                    int j = 0;
                    while (j <= input)
                    {
                        Console.WriteLine("The value of the variable j is: " + j.ToString());
                        j++;
                    }
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }


                else if ((input > 15) && (input <= 20))
                {
                    Console.WriteLine("Executing a Do/While Loop");
                    Console.WriteLine("The Do/While loop will iterate " + input.ToString() + " times");

                    int k = 0;
                    do
                    {
                        Console.WriteLine("The value of the variable k is: " + k.ToString());
                        k++;
                    }
                    while (k <= input);

                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Enter an integer between 0 and 20 and try again ");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
            }

            catch
            {
                Console.WriteLine("Please enter a integer value and try again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}