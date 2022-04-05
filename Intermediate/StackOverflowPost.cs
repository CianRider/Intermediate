using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class StackOverflowPost
    {
        public string Title { get; set; }
        public DateTime Createddt { get; set; }
        public string Description { get; set; }
        public int Vote { get; set; }

        public StackOverflowPost(string title, DateTime createddt, string description, int vote)
        {
            Title = title;
            Createddt = createddt;
            Description = description;
            Vote = vote;
        }
    }
    public class StackOverflowPostComment
    {
        public string Title { get; set; }
        public DateTime Createddt { get; set; }
        public string Description { get; set; }
        public int Vote { get; set; }
        public int PostComment { get; set; }

        public StackOverflowPostComment(string title, DateTime createddt, string description, int vote, int connectPost)
        {
            Title = title;
            Createddt = createddt;
            Description = description;
            Vote = vote;
            PostComment = connectPost;
        }
    }

}
