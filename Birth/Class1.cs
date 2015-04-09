using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birth
{
    public class Class1
    {
        public enum YearFormat
        {
            c = 0, // 民國
            w = 1  // 西元
        }
        public int GetBirthYear(int Age, YearFormat format)
        {
            int WestYear = (DateTime.Now.Year - Age);

            if (format == YearFormat.c)
                return (WestYear - 1911);
            else if (format == YearFormat.w)
                return WestYear;

            return 0;
        }
    }
}
