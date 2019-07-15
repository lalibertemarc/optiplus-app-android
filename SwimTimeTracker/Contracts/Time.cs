using System;
namespace SwimTimeTracker.Contracts
{
    public class Time
    {
        public int Id { get; set; }
        public int Distance { get; set; }
        public string Style { get; set; }
        public Time time { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
    }
}
