using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class TeacherRegistration
    {
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual Subject Subject { get; set; } = null!;
        public virtual Teacher Teacher { get; set; } = null!;
    }
}
