using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Performance
    {
        public int PerformanceId { get; set; }
        public string? PerformanceDetails { get; set; }
        public int? StudentId { get; set; }
        public int? TeacherId { get; set; }
        public int? SubjectId { get; set; }
        public int? ScheduleId { get; set; }

        public virtual Schedule? Schedule { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
