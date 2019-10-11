using System;
using Android.Arch.Lifecycle;

namespace SwimTimeTracker.ViewModels
{
    public class SwimmerViewModel : ViewModel
    {
        int _id;
        string _name;
        char _sex;
        string _coachName;


        public SwimmerViewModel(int id, string name, char sex, string coachName)
        {
            _id = id;
            _name = name;
            _sex = sex;
            _coachName = coachName;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetSex()
        {
            return _sex.CompareTo('M') == 0 ? "Sex : Male" : "Sex : Female";
        }

        public string GetCoachName()
        {
            return $"Coach : {_coachName}";
        }

        public int GetId()
        {
            return _id;
        }
    }
}
