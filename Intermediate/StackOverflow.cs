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
                    Console.WriteLine("Invalid Menu Selected. Please select option from provided list.\n\n");
                else
                {
                    if (iFunction <= 0 || iFunction > 3)
                    {
                        Console.WriteLine("Invalid Function Selected. Please select option from provided list.\n\n");
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
            bool lExit = false;

            var options = Stack.Entries(out int max);
            while (!lExit)
            {
                DisplayHeader();

                if (options == "")
                {
                    Console.WriteLine("\tNo Posts to browse. Returning to main menu....");
                    return;
                }

                Console.WriteLine(options);
                Console.WriteLine("\n\nLeave Program: 'Exit'");
                cInput = Console.ReadLine();

                lExit = (cInput == "Exit" || cInput == "exit" || cInput == "0" || cInput == "");

                if (lExit) return;

                if (!int.TryParse(cInput, out iFunction))
                    Console.WriteLine("Invalid Post Selected. Please select option from provided list.\n\n");
                else
                {
                    if (iFunction <= 0 || iFunction > max)
                    {
                        Console.WriteLine("Invalid Post Selected. Please select option from provided list.\n\n");
                        return;
                    }

                    ViewPost(iFunction - 1);

                }

            }
        }

        private void ViewPost(int iFocusEntry)
        {
            int iFunction;
            bool lExit = false;

            var post = Stack.Post(iFocusEntry);
            while (!lExit)
            {
                DisplayHeader();

                if (post == "")
                {
                    Console.WriteLine("\tNo Entries to browse. Returning to main menu....");
                    return;
                }

                Console.WriteLine(post);
                Console.WriteLine("\n");
                Console.WriteLine(Stack.Comment(iFocusEntry));
                Console.WriteLine("\n\n\n");
                Console.WriteLine("\t1) Upvote");
                Console.WriteLine("\t2) Downvote");
                //Console.WriteLine("\t3) View Comments");
                Console.WriteLine("\t3) Add Comments");
                Console.WriteLine("\tLeave Program: 'Exit'");
                cInput = Console.ReadLine();

                lExit = (cInput == "Exit" || cInput == "exit" || cInput == "0" || cInput == "");

                if (lExit)
                {
                    BrowseScreen();
                    return;
                }
                if (!int.TryParse(cInput, out iFunction))
                    Console.WriteLine("Invalid Operation Selected. Please select option from provided list\n\n");
                else
                {
                    if (iFunction <= 0 || iFunction > 3)
                    {
                        Console.WriteLine("Invalid Operation Selected. Please select option from provided list\n\n");
                        return;
                    }

                    switch (iFunction)
                    {
                        case 1:
                            Stack.UpDownVode(iFocusEntry, 1);
                            post = Stack.Post(iFocusEntry);
                            break;
                        case 2:
                            Stack.UpDownVode(iFocusEntry, -1);
                            post = Stack.Post(iFocusEntry);
                            break;
                        case 3:
                            Stack.CreateComment(iFocusEntry);
                            break;
                        default:
                            Console.WriteLine("How did you get here!");
                            break;

                    }
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