using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1B_Mocking
{
    public class ToUpperCaseManipulator : IStringManipulator
    {
        public string Manipulate(string text)
        {
            return text.ToUpper();
        }
    }
}
