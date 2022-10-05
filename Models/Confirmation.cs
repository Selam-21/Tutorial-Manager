using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Confirmation
    {
        public int ConfirmationId { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string? ConfirmationContent { get; set; }
        public int? ParentId { get; set; }
        public int? PaymentId { get; set; }

        public virtual Parent? Parent { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}
