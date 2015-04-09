using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebApplication1.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CalYear()
        {
            Born.Class1 cal = new Born.Class1();
            int inputAge = 30;
            int expect = 1985;

            Assert.AreEqual(expect, cal.GetBirthYear(inputAge, Born.Class1.YearFormat.W));
        }
    }
}
