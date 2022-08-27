using DayOfBirth;
using System;

namespace DayOfBirthApp
{
    /// <summary>
    /// Obiekt, który przechowuje dane, wykonuje obliczenia i wyświetla wynik
    /// </summary>
    class DayofBirth
    {
        /// <summary>
        /// Typ oblicza na podstawie DateTime dzień tygodnia z podanej daty
        /// </summary>
        public DayCalculator Calculator { get; set; }
        /// <summary>
        /// Data podana przez użytkownika
        /// </summary>
        public DateTime UserDayOfBirth { get; set; }
        /// <summary>
        /// Dni tygodnia
        /// </summary>
        public NameOfTheWeek DayOfTheWeek { get; set; }
        public DayofBirth()
        {
                
        }

        /// <summary>
        /// Przywitanie się programu 
        /// </summary>
         public void Hello()
        {
            Console.WriteLine("Cześć! Jestem aplikacją obliczającą w który dzień tygodnia się urodziłeś!");
            Console.WriteLine("Proszę podaj swoją datę urodzin");
            Console.WriteLine("Format: DD/MM/RRRR");
             Calculator = new DayCalculator();
        }
        /// <summary>
        /// Wczytanie daty podanej przez użytkownika
        /// </summary>
        public void AddUserDate()
        {
            var UserDate = Console.ReadLine();
            // Sprawdzamy czy użytkownik podał dobry format daty
            var condition = DateTime.TryParse(UserDate, out var date);
            
            while (condition)
            {
                UserDayOfBirth = date;
                return;
            }
            Console.WriteLine("Zły format - spróbuj jeszcze raz: ");
            AddUserDate();
        }
        /// <summary>
        /// Obliczamy dzień tygodnia
        /// </summary>
        public void CalculateDayOfBirth()
        {
            //if (UserDayOfBirth == null)
            //{
            //    Console.WriteLine("Próbowano obliczyć dzień tygodnia bez podania daty urodzin");
            //}


            // Przechodzimy do obiektu Calculator gdzie znajduje się algorytm obliczania dnia tygodnia
            DayOfTheWeek = Calculator.CalculateTheDayOfTheWeek(UserDayOfBirth);
        }
        /// <summary>
        /// Wyświetla wynik obliczeń
        /// </summary>
        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to " + DayOfTheWeek.ToPolishString());
        }
    }
}
