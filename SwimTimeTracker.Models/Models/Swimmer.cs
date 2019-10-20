using System;
namespace SwimTimeTracker.Models.Models
{
    public class Swimmer : IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Sexe { get; set; }
        public string CoachName { get; set; }
    }
}
