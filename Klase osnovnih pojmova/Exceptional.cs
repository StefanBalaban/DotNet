using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice
{
    // Ovaj custom exception kao parametre prima string sa porukom greške i Exception objekat koji sadrži "pravi" razlog problema
    // Zamisao ovoga je da korisniku pošaljemu neku generičnu poruku, dok bi developer kroz innnerException znao pravi razlog
    public class ExceptionalException : Exception
    {
        public ExceptionalException(string message, Exception innerException)
            :base(message, innerException)
        {
        }
    }
    class Exceptional
    {
        private readonly string _adress;
        public Exceptional(string adress)
        {
            _adress = adress;
        }
        // Ova metoda treba da iščita datoteku iz adrese koja se nalazi u string-u _adress, u slučaju da to nije moguće ispiše exception Message i throw-a ga
        public dynamic ReadFileFromAdress()
        {
            try
            {
                using (var datoteka = new StreamReader(@$"{_adress}"))
                {
                    return datoteka;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Žao nam je, desila se neočekivana greška");
                Console.WriteLine($"Podaci o greški: {ex.Message}");
                throw;
            }
        }
        // Ova metoda prima broj i ako nije 5 throw-a novi Exception sa porukom problema
        // Catch dio throw-a custom exception ExceptionalException i kao parametar, innerException šalje prvi exception        
        public bool NumberFiveChecker(int possibleFive)
        {
            try
            {
                if (possibleFive != 5)
                    throw new Exception("That is not a number five");
                return true;
            }
            catch (Exception ex)
            {

                throw new ExceptionalException("Sorry, but an error has ocured", ex);
            }
        }
    }
}
