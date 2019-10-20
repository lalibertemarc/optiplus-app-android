using System;
namespace SwimTimeTracker.Models.Models
{
    public class Swim : IBaseModel
    {
        public int Id { get; set; }
        public int Distance { get; set; }
        public string Style { get; set; }
        public bool IsLongCourse { get; set; }
    }
}
