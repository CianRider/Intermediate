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
                Console.WriteLine("Exercise 1 = 1");
                Console.WriteLine("Exercise 2 = 2");
                Console.WriteLine("Exercise 3 = 3");
                Console.WriteLine("Exercise 4 = 4");
                Console.WriteLine("Exercise 5 = 5");
                Console.WriteLine("Leave Program: 'Exit'");

                cInput = Console.ReadLine();

                lExit = (cInput == "Exit" || cInput == "exit" || cInput == "0" || cInput == "");

                if (lExit) break;

                if (!int.TryParse(cInput, out iFunction))
                    Console.WriteLine("Invalid Menu Selected. Please choose valid option.\n\n");
                else
                {
                    if (iFunction <= 0 || iFunction > 5)
                    {
                        Console.WriteLine("Invalid Menu Selected. Please choose valid option.\n\n");
                    }

                    switch (iFunction)
                    {
                        case 1:
                            Console.WriteLine("Navigating to Excersice 1 Menu... \n\n");
                            var Classes = new ExcerciseClass();
                            Classes.Classes();
                            break;
                        case 2:
                            Console.WriteLine("Gonna\n\n");
                            break;
                        case 3:
                            Console.WriteLine("Give\n\n");
                            break;
                        case 4:
                            Console.WriteLine("You\n\n");
                            break;
                        case 5:
                            Console.WriteLine("Up\n\n");
                            break;
                        default:
                            Console.WriteLine("How did you get here!");
                            break;
                    }
                }
            }
        }
    }
}
