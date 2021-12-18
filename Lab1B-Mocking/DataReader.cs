using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1B_Mocking
{
    public class DataReader : IStringDataProvider
    {
        private const string FILEPATH = @"C:\Users\bijay\CleanCode\Lab1B-Mocking\Lab1B-Mocking\TestFile.txt";


        public string Read()
        {
            using (StreamReader sr = new StreamReader(FILEPATH))
            {
                string? line = sr.ReadLine();

                if (line is null) throw new Exception("File was null");

                if (String.IsNullOrEmpty(line)) throw new Exception("First line was empty");

                string? secondLine = sr.ReadLine();
                if (secondLine is not null) throw new Exception("File contained more than one line");

                return line;
            }
        }       
    }
}
