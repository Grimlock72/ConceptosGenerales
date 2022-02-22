using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConceptosGenerales
{
    class GreetCountries
    {
        public void InputFile(string country)
        {
            //String country;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Test\\countries.txt");

                //Read the first line of text
                country = sr.ReadLine();
                
                //Continue to read until you reach end of file
                while (country != null)
                {
                    //Write the line to console window
                    Console.WriteLine(country);
                    
                    //Read the next line
                    country = sr.ReadLine();
                }
                //close the file
                //sr.Close();

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        internal void OutputFile(string country)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(string.Format("C:\\Test\\Countries {0:yyyy-MM-dd_HH-mm}.txt", DateTime.Now));

                //Write a line of text
                sw.WriteLine("Saludos hasta " + country + "!!!");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
