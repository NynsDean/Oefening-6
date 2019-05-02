using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6.Oefeningen.web.Entities
{
    public class ArrivingFlight
    {
        public Guid Id { get; set; }

        public string  Origin { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime ActualTime { get; set; }

        public Airline Airline { get; set; }
    }
}
