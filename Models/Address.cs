using System;
using System.Collections.Generic;

namespace Tutorial_Manager.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string? City { get; set; }
        public string? KefleK { get; set; }
        public int? Woreda { get; set; }
        public int? HouseNumber { get; set; }
        public int? StudentId { get; set; }
        public int? TeacherId { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
