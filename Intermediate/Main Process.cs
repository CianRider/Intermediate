using System;
using System.Collections.Generic;
using System.Text;
/*-----------------------------------------------------------------------
 This program is being developed as the main hub to interact with all of
 sub programs created during the development training course.
-----------------------------------------------------------------------*/
namespace IntermediateExcercise
{
    class ExcMainProg
    {
        static void Main(string[] args)
        {
            string cInput;
            int iFunction;
            bool lExit = false;

            while (!lExit)
            {

                Console.WriteLine("Select Exercise to run:");
                Console.WriteLine("Exercise 5.1 = 1");
                Console.WriteLine("Exercise 5.2 = 2");
                Console.WriteLine("Exercise 6   = 3");
                Console.WriteLine("Exercise 8   = 4");
                Console.WriteLine("Testing      = 5");
                Console.WriteLine("Leave Program: 'Exit'");

                cInput = Console.ReadLine();

                if (cInput == "Exit" || cInput == "exit" || cInput == "0")
                {
                    lExit = true;
                    break;
                }

                iFunction = Convert.ToInt32(cInput);
                
                if (iFunction <= 0 || iFunction > 5)
                {
                    Console.WriteLine("Invalid Function Selected. Please choose valid option.");;
                }
                
                switch (iFunction)
                {
                    case 1:
                        Console.WriteLine("Never");
                        break;
                    case 2:
                        Console.WriteLine("Gonna");
                        break;
                    case 3:
                        Console.WriteLine("Give");
                        break;
                    case 4:
                        Console.WriteLine("You");
                        break;
                    case 5:
                        Console.WriteLine("Up");
                        break;
                }
            }
        }
    }
}
