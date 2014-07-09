using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KerentaNET.Models
{
    public class Car
    {
        public Car()
        {
        }

        [Required]
        public int CarId { get; set; } 

        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Year { get; set; }

        [Required]
        public string Plate { get; set; }

        [Range(0.1, 1.0)]
        public double Rate { get; set; }

        public int OwnerId { get; set; }

        public virtual UserProfile UserProfile { get; set; }

    }

    public class CarDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }

}