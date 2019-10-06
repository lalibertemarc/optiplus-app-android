using System;
namespace SwimTimeTracker.Models
{
    public class Time
    {
        public int Id { get; set; }
        public int Distance { get; set; }
        public string Style { get; set; }
        public Time ActualTime { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
    }
}
