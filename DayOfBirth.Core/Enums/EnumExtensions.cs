using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfBirth
{

    public static class EnumExtensions
    {
       
        
        public static string ToPolishString (this NameOfTheWeek dayOfTheWeek)
        {
            switch (dayOfTheWeek)
            {
                case NameOfTheWeek.Monday:
                    return "Poniedziałek";
                case NameOfTheWeek.Tuesday:
                    return "Wtorek";
                case NameOfTheWeek.Wednesday:
                    return "Środa";
                case NameOfTheWeek.Thursday:
                    return "Czwartek";
                case NameOfTheWeek.Friday:
                    return "Piątek";
                case NameOfTheWeek.Saturday:
                    return "Sobota";
                case NameOfTheWeek.Sunday:
                    return "Niedziela";
                default:
                    return "Zła data";
            }
        }

    }


}
