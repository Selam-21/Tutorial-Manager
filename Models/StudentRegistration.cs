using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class StudentRegistration
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual Student Student { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
