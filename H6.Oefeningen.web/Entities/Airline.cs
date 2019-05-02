using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H6.Oefeningen.web.Entities
{
    public class Airline
    {   [Key]
        public long Id { get; set; }

        [Required]
        public string AirlineName { get; set; }

        public ICollection<ArrivingFlight> ArrivingFlights { get; set; }

        public ICollection<DepartingFlight> DepartingFlights { get; set; }
    }
}
