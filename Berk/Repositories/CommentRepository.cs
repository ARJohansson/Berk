using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Repositories;
using Berk.Models;

namespace Berk.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private List<Comment> comments = new List<Comment>();
        public List<Comment> Comments {get {return comments;} }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
    }
}
