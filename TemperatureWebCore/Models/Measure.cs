using System;
using System.ComponentModel.DataAnnotations;

namespace TemperatureWebCore.Models
{
    public class Measure
    {
        [Required]
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public double Temperature { get; set; }
    }
}
