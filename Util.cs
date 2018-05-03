using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteGen
{
    class Util
    {
        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }
}
