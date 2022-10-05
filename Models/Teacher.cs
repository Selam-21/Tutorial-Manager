using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Addresses = new HashSet<Address>();
            Attendances = new HashSet<Attendance>();
            Comments = new HashSet<Comment>();
            Performances = new HashSet<Performance>();
            Students = new HashSet<Student>();
            TeacherRegistrations = new HashSet<TeacherRegistration>();
        }

        public int TeacherId { get; set; }
        public string TeacherFname { get; set; } = null!;
        public string TeacherLname { get; set; } = null!;
        public string? Cv { get; set; }
        public bool? Available { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Performance> Performances { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<TeacherRegistration> TeacherRegistrations { get; set; }
    }
}
