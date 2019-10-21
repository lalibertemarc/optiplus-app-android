using System;
namespace SwimTimeTracker.Models.Models
{
    public class Event : IBaseModel
    {
        public int Id { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Level { get; set; }
    }
}
