using System;
using System.Collections.Generic;
using System.Linq;


namespace IntermediateExcercise
{
    class OverflowMethods
    {
        var Titles = new List<string>();
        private string[] Descriptions;
        private DateTime[] DateCreated;
        private int[] Likes;
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime Createddt { get; set; }
        private int Vote { get; set; }

        //public OverflowMethods()
        //{
        //    Titles = new string[] { };
        //    Descriptions = new string[] { };
        //    DateCreated = new DateTime[] { };
        //    Likes = new int[] { };
        //}

        public void CreatePost()
        {
            string cInput;
            
            Console.WriteLine("Post Title:");
            cInput = Console.ReadLine();

            Title = cInput;
            Createddt = DateTime.Today;
            cInput = "";

            Console.WriteLine("Post Title:\t{0}", Title);
            Console.WriteLine("Created:\t{0}", Createddt);

            Console.WriteLine("Description:");
            cInput = Console.ReadLine();

            Description = cInput;

            Console.WriteLine("Post Title:\t{0}", Title);
            Console.WriteLine("Created:\t{0}", Createddt);

            Console.WriteLine("Description:\n{0}", Description);
            CreateListEntry();
        }

        private void CreateListEntry()
        {
        }

        public void ViewEntries()
        {
            foreach(var tit in Titles)
            {
                Console.WriteLine(tit);
            }

            Console.WriteLine(Title);
        }

        public string Entries(out int entryNo)
        {
            var enties  = "";
            entryNo = 0;
            string ctitle;

            if (Likes == null || Likes.Count() == 0) return "";
            else
            {

                foreach (int like in Likes)
                {
                    ctitle = Titles.ElementAt(entryNo);

                    entryNo++;

                    if (enties == "")
                    {
                        enties = Convert.ToString(entryNo) + ")\t" + ctitle + "\t\t" + Convert.ToString(like);
                    }
                    else
                    {
                        enties = enties + "\n" + Convert.ToString(entryNo) + ")\t" + ctitle + "\t\t" + Convert.ToString(like);
                    }
                }

            }

            return enties;
        }
    }
}