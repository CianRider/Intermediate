using Intermediate;
using System;
using System.Collections.Generic;
using System.Linq;


namespace IntermediateExcercise
{
    class OverflowMethods
    {
        public List<StackOverflowPost> Posts = new List<StackOverflowPost>();
        public List<StackOverflowPostComment> Comments = new List<StackOverflowPostComment>();
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime Createddt { get; set; }

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

        public void CreateComment(int Post)
        {
            string cInput;

            Console.WriteLine("Comment Title:");
            cInput = Console.ReadLine();

            Title = cInput;
            Createddt = DateTime.Today;
            cInput = "";

            Console.WriteLine("Comment Title:\t{0}", Title);
            Console.WriteLine("Created:\t{0}", Createddt);

            Console.WriteLine("Description:");
            cInput = Console.ReadLine();

            Description = cInput;

            Console.WriteLine("Comment Title:\t{0}", Title);
            Console.WriteLine("Created:\t{0}", Createddt);

            Console.WriteLine("Description:\n{0}", Description);
            CreateListEntry(Title, Createddt, Description, Post);
        }

        private void CreateListEntry(string Title, DateTime Createddt, string Description)
        {
            Posts.Add(new StackOverflowPost(Title, Createddt, Description, 0)); //Adds a new Post object to the list
        }

        private void CreateListEntry(string Title, DateTime Createddt, string Description, int Post)
        {
            Comments.Add(new StackOverflowPostComment(Title, Createddt, Description, 0, Post)); //Adds a new Post object to the list
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
            entryNo = 0;
            if (Posts.Count == 0) return "";
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
        }

        public string Post(int Element)
        {
            string fullPost = "";

            var post = Posts.ElementAt(Element);

            fullPost = Convert.ToString(post.Createddt) + "\n"
                     + Convert.ToString(post.Vote)      + "\t\t" + post.Title + "\n\n"
                     + post.Description;
            
            return fullPost;
        }

        public void UpDownVode(int Element, int Change)
        {
            var post = Posts.ElementAt(Element);

            post.Vote = post.Vote += Change;
        }

        public string Comment(int Element)
        {
            string fullComments = "";

            var comments = Comments.FindAll(e => e.PostComment == Element).ToList();

            foreach(var comm in comments)
            {
                fullComments = fullComments
                             + Convert.ToString(comm.Createddt) + "\n"
                             + comm.Title + "\n"
                             + comm.Description + "\n\n";
            }

            return fullComments;
        }
    }
}