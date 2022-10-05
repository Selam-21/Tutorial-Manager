using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int? ParentId { get; set; }
        public int? TeacherId { get; set; }

        public virtual Parent? Parent { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
