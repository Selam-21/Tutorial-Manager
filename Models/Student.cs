using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Student
    {
        public Student()
        {
            Addresses = new HashSet<Address>();
            Attendances = new HashSet<Attendance>();
            Performances = new HashSet<Performance>();
            StudentRegistrations = new HashSet<StudentRegistration>();
        }

        public int StudentId { get; set; }
        public string StudentFname { get; set; } = null!;
        public string StudentLname { get; set; } = null!;
        public int? Grade { get; set; }
        public int? ParentId { get; set; }
        public int? TeacherId { get; set; }

        public virtual Parent? Parent { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Performance> Performances { get; set; }
        public virtual ICollection<StudentRegistration> StudentRegistrations { get; set; }
    }
}
