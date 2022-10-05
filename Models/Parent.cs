using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Parent
    {
        public Parent()
        {
            Comments = new HashSet<Comment>();
            Confirmations = new HashSet<Confirmation>();
            Payments = new HashSet<Payment>();
            Students = new HashSet<Student>();
        }

        public int ParentId { get; set; }
        public string ParentFname { get; set; } = null!;
        public string ParentLname { get; set; } = null!;

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Confirmation> Confirmations { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
