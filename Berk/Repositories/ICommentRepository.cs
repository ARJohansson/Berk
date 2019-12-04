using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;

namespace Berk.Repositories
{
    public interface ICommentRepository
    {
        List<Comment> Comments { get; }
        void AddComment(Comment comment);
    }
}
