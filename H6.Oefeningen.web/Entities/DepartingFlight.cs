using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H6.Oefeningen.web.Entities
{
    public class DepartingFlight
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public DateTime ScheduledTime { get; set; }

        [Required]
        public DateTime ActualTime { get; set; }

        [Required]
        public Airline Airline { get; set; }
    }
}
