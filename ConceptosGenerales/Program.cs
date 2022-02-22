using System;

namespace ConceptosGenerales
{
    class Program
    {
        public static string country { get; private set; }

        static void Main(string[] args)
        {
            //var sendDataCountry = InputFile(country);
            //var getDataCountry = OutputFile(sendDataCountry);

            GreetCountries greetCountries = new GreetCountries();
            greetCountries.InputFile(country);
            greetCountries.OutputFile(country);
            greetCountries.Fail();
            Console.ReadKey();
        }
    }
}
