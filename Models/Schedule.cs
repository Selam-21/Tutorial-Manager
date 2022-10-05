using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            Attendances = new HashSet<Attendance>();
            Performances = new HashSet<Performance>();
        }

        public int ScheduleId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public TimeSpan? Session { get; set; }
        public int? SubjectId { get; set; }

        public virtual Subject? Subject { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Performance> Performances { get; set; }
    }
}
