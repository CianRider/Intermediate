using System;


namespace IntermediateExcercise
{
    class StackOverflow
    {

        string cInput;

        OverflowMethods Stack = new OverflowMethods();

        public void MainScreen()
        {
            int iFunction;
            bool lExit = false;

            while (!lExit)
            {
                DisplayHeader();
                Console.WriteLine("\t1) Create Post");
                Console.WriteLine("\t2) Browse Posts");
                Console.WriteLine("\tLeave Program: 'Exit'");

                cInput = Console.ReadLine();

                lExit = (cInput == "Exit" || cInput == "exit" || cInput == "0" || cInput == "");

                if (lExit) break;

                if (!int.TryParse(cInput, out iFunction))
                    Console.WriteLine("Invalid Menu Selected. Returning to main program.\n\n");
                else
                {
                    if (iFunction <= 0 || iFunction > 3)
                    {
                        Console.WriteLine("Invalid Excersice Selected. Returning to main program.\n\n");
                        return;
                    }

                    switch (iFunction)
                    {
                        case 1:
                            Stack.CreatePost();
                            break;
                        case 2:
                            BrowseScreen();
                            break;
                        case 3:
                            Stack.ViewEntries();
                            break;
                        default:
                            Console.WriteLine("How did you get here!");
                            break;

                    }
                }
            }
        }

        private void BrowseScreen()
        {
            int iFunction;
            bool lExit2 = false;

            var options = Stack.Entries(out int max);
            DisplayHeader();

            if (options == "")
            {
                Console.WriteLine("\tNo Entries to browse. Returning to main menu....");
                return;
            }

            Console.WriteLine(options);
            cInput = Console.ReadLine();

            lExit2 = (cInput == "Exit" || cInput == "exit" || cInput == "0" || cInput == "");

            if (lExit2) return;

            if (!int.TryParse(cInput, out iFunction))
                Console.WriteLine("Invalid Menu Selected. Returning to main program.\n\n");
            else
            {
                if (iFunction <= 0 || iFunction > max)
                {
                    Console.WriteLine("Invalid Excersice Selected. Returning to main menu.\n\n");
                    return;
                }

            }
        }

        private void DisplayHeader()
        {
            Console.WriteLine("\n");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                       StackOverFlow Main Menu                              *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
        }
    }
}