using System;
using System.ComponentModel.DataAnnotations;

namespace halloween_party.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your age")]
        public string guestAge { get; set; }
        [Required(ErrorMessage = "Please enter your arrival time")]
        public string arrival { get; set; }
        [Required(ErrorMessage = "Please specify whether you require parking assistance")]
        public bool? parking { get; set; }
    }
}

