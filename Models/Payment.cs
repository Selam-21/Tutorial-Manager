using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Confirmations = new HashSet<Confirmation>();
            Subjects = new HashSet<Subject>();
        }

        public int PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? Amount { get; set; }
        public int? ParentId { get; set; }

        public virtual Parent? Parent { get; set; }
        public virtual ICollection<Confirmation> Confirmations { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
