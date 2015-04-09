using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Born
{
    public class Class1
    {
        public enum YearFormat
        {
            C = 0, // 民國年
            W = 1  // 西元年
        }
        public int GetBirthYear(int Age, YearFormat format)
        {
            int WestYear = (DateTime.Now.Year - Age);

            if (format == YearFormat.C)
                return (WestYear - 1911);
            else if (format == YearFormat.W)
                return WestYear;

            return 0;
        }
    }
}
