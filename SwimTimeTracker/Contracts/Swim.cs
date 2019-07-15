﻿using System;
namespace SwimTimeTracker.Contracts
{
    public class Swim
    {
        public int Id { get; set; }
        public int Distance { get; set; }
        public string Style { get; set; }
        public bool IsLongCourse { get; set; }
    }
}
