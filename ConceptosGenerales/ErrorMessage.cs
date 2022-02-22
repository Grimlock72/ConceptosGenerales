using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConceptosGenerales
{
    class ErrorMessage
    {
        static void Fail()
        {
                try
                {
                StreamReader StreamReaderfilereader;
                using (StreamReaderfilereader = new StreamReader("nofile.txt"))
                    {
                        filereader.ReadToEnd();
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex);
                }
            
            Console.ReadKey();
        }
    }
}
