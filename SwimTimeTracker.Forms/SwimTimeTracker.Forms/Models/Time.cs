using System;

namespace SwimTimeTracker.Models.Models
{
    public class Time : IBaseModel
    {
        public int Id { get; set; }
        public int Distance { get; set; }
        public string Style { get; set; }
        public string ActualTime { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
    }
}
