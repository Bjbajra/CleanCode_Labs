using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1B_Mocking
{
    public class FixedStringProvider : IStringDataProvider
    {
        public string Read()
        {
            return "Nepal";
        }
    }
}
