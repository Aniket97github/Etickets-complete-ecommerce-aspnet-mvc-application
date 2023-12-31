﻿using System.ComponentModel.DataAnnotations;

namespace Etickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }

        //Relationships 
        public List<Movie> Movies { get; set; }
    }
}
