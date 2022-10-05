using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Attendances = new HashSet<Attendance>();
            Performances = new HashSet<Performance>();
            Schedules = new HashSet<Schedule>();
            StudentRegistrations = new HashSet<StudentRegistration>();
            TeacherRegistrations = new HashSet<TeacherRegistration>();
        }

        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public int? Grade { get; set; }
        public int? PaymentId { get; set; }

        public virtual Payment? Payment { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Performance> Performances { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<StudentRegistration> StudentRegistrations { get; set; }
        public virtual ICollection<TeacherRegistration> TeacherRegistrations { get; set; }
    }
}
