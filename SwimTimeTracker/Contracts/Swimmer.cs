using System;
namespace SwimTimeTracker.Contracts
{
    public class Swimmer
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public char Sex { get; set; }
        public string CoachName { get; set; }
    }
}
