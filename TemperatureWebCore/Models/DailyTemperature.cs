using System;
using System.ComponentModel.DataAnnotations;

namespace TemperatureWebCore.Models
{
    public class DailyTemperature
    {
        [Key]
        public DateTime Time { get; set; }
        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set; }
        public double AvgTemperature { get; set; }
    }
}
