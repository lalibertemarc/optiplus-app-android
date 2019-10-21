using System;
using System.Collections.Generic;
using System.Text;

namespace SwimTimeTracker.Forms.Models
{
    public enum MenuItemType
    {
        Overview,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
