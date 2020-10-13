using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excercise_3_Timesheets.Models
{
    public class Location
    {
        public Location()
        {

        }

        public Location(String name, String address) : this()
        {
            Name = name;
            Address = address;
        }

        public int LocationId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
