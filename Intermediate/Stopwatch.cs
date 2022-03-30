using System;
using System.Diagnostics;
using System.Threading;


namespace IntermediateExcercise
{
    class Laptimer
    {


        bool lRunning = false;

        Stopwatch stopwatch = new Stopwatch();


        public void Timer()
        {
            string cInput;
            int iFunction;
            bool lExit = false;


            while (!lExit)
            {
                Console.WriteLine("Select Stopwatch Function:");
                Console.WriteLine("Start Stopwatch   = 1");
                Console.WriteLine("Return Split time = 2");
                Console.WriteLine("Stop Stopwatch    = 3");
                Console.WriteLine("Leave Program: 'Exit'");

                cInput = Console.ReadLine();

                lExit = (cInput == "Exit" || cInput == "exit" || cInput == "0" || cInput == "");

                if (lExit) break;

                if (!int.TryParse(cInput, out iFunction))
                    Console.WriteLine("Invalid Function Selected. Please choose valid option.\n\n");
                else
                {

                    if (iFunction <= 0 || iFunction > 3)
                    {
                        Console.WriteLine("Invalid Function Selected.\n\n");
                    }

                    switch (iFunction)
                    {
                        case 1:
                            Console.WriteLine("\n\n{0}\n\n", Start());
                            break;
                        case 2:
                            Console.WriteLine("\n\n{0}\n\n", Split());
                            break;
                        case 3:
                            Console.WriteLine("\n\n{0}\n\n", Stop());
                            break;
                        default:
                            Console.WriteLine("How did you get here!");
                            break;

                    }
                }

            }

        }

        private string Start()
        {
            string cReturnVal;

            if (!lRunning)
            {
                lRunning = true;
                stopwatch.Start();
                cReturnVal = "Starting stopwatch.";
            }
            else
            {
                cReturnVal = "Stopwatch is already running. Can't start a second one.";
            }

            return cReturnVal;
        }

        private string Stop()
        {
            string cReturnVal;

            if (!lRunning)
            {
                cReturnVal = "No running stopwatch to stop";
            }
            else
            {
                lRunning = false;
                stopwatch.Stop();
                cReturnVal = "Stopping: " + Convert.ToString(stopwatch.Elapsed);
            }

            return cReturnVal;
        }

        private string Split()
        {
            string cReturnVal;

            if (!lRunning)
            {
                cReturnVal = "No running stopwatch. Cannot return Split";
            }
            else
            {
                cReturnVal = "Stopwatch Split: " + Convert.ToString(stopwatch.Elapsed);
            }

            return cReturnVal;
        }
    }
}