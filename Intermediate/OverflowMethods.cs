using Intermediate;
using System;
using System.Collections.Generic;
using System.Linq;


namespace IntermediateExcercise
{
    class OverflowMethods
    {
        //List<String> Titles = new List<string>(); //This needed a type declaration (var -> List<string>)
        public List<StackOverflowPost> Posts = new List<StackOverflowPost>(); //Having the titles separate from the posts is too complicated. I created a class and made a list of that.
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
            CreateListEntry(Title, Createddt, Description);
        }

        private void CreateListEntry(string Title, DateTime Createddt, string Description)
        {
            Posts.Add(new StackOverflowPost(Title, Createddt, Description, 0)); //Adds a new Post object to the list
        }

        public void ViewEntries()
        {
            foreach(var post in Posts) //Pull from the posts
            {
                Console.WriteLine(post.Title);
            }

            //Console.WriteLine(Title);
        }

        public string Entries(out int entryNo)
        {
            //This is a little complicated. I'm rewriting it.
            entryNo = 0;
            if (Posts.Count == 0)
            { 
                return "";
            }
            else
            {                
                string entries = "";
                foreach (var post in Posts)
                {
                    entryNo++;

                    if (entries == "")
                    {
                        entries = Convert.ToString(entryNo)+ ")\t" + post.Title + "\t\t" + Convert.ToString(post.Vote);
                    }
                    else
                    {
                        entries = entries + "\n" + Convert.ToString(entryNo) + ")\t" + post.Title + "\t\t" + Convert.ToString(post.Vote);
                    }
                }
                return entries;
            }

            //var enties = "";
            //entryNo = 0;
            //string ctitle;

            //if (Likes == null || Likes.Count() == 0) return ""; //Why are you checking by like count? Surely it should be post count
            //else
            //{

            //    foreach (int like in Likes)
            //    {
            //        ctitle = Titles.ElementAt(entryNo);

            //        entryNo++;

            //        if (enties == "")
            //        {
            //            enties = Convert.ToString(entryNo) + ")\t" + ctitle + "\t\t" + Convert.ToString(like);
            //        }
            //        else
            //        {
            //            enties = enties + "\n" + Convert.ToString(entryNo) + ")\t" + ctitle + "\t\t" + Convert.ToString(like);
            //        }
            //    }

            //}

            //return enties;
        }
    }
}