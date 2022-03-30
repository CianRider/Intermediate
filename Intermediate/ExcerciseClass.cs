using System;

/*-----------------------------------------------------------------------
 This program is being developed as the interface between the main menu
 and the sub programs being developed for the excercises
-----------------------------------------------------------------------*/


namespace IntermediateExcercise
{
    class ExcerciseClass
    {
        public void Classes()
        {

            var lExit = false;

            Console.WriteLine("Please Select Which Function you wish to run:");
            Console.WriteLine("Launch Stopwatch = 1");
            //Console.WriteLine("Display Maximum = 2");
            //Console.WriteLine("Determine Picture Orientation = 3");
            //Console.WriteLine("Test Speed Camera = 4");
            Console.WriteLine("Leave Program: 'Exit'");

            var cInput = Console.ReadLine();


            lExit = (cInput == "Exit" || cInput == "exit" || cInput == "0" || cInput == "");

            if (lExit)
            {
                Console.WriteLine("Exiting to main program.\n\n");
                return;
            }

            int iFunction;

            if (!int.TryParse(cInput, out iFunction))
                Console.WriteLine("Invalid Menu Selected. Returning to main program.\n\n");
            else
            {

                if (iFunction <= 0 || iFunction > 1)
                {
                    Console.WriteLine("Invalid Excersice Selected. Returning to main program.\n\n");
                    return;
                }

                switch (iFunction)
                {
                    case 1:
                        Console.WriteLine("Initialising Stopwatch program");
                        var Timer = new Laptimer();
                        Timer.Timer();
                        break;
                    case 2:
                        Console.WriteLine("Initiating Max Number Comparison");
                        break;
                    case 3:
                        Console.WriteLine("Initiate Picture Orientation");
                        break;
                    case 4:
                        Console.WriteLine("Initiating Speed Camera Logic");
                        break;
                    default:
                        Console.WriteLine("How did you get here!");
                        break;

                }
            }
        }
    }
}
