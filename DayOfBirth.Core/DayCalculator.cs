using DayOfBirth;
using System;
using System.Collections.Generic;

namespace DayOfBirth
{
    public class DayCalculator
    {
        /// <summary>
        /// Algorytm obliczania dnia tygodnia z daty
        /// </summary>
        /// <param name="date">Data która będzie obliczana</param>
        /// <returns>Dzień tygodnia w eunumie</returns>
        public NameOfTheWeek CalculateTheDayOfTheWeek(DateTime date)
        { 
{
                var t = new List <int> { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
                var day = date.Day;
                var month = date.Month;
                var year = date.Year;
                if (month < 3)
                {
                    year -= 1;
                }
                var CalculatedResult = (year + year / 4 - year / 100 + year / 400 + t[month - 1] + day) % 7;
                
                return (NameOfTheWeek)(CalculatedResult-1);
            }
        }
    }
}
