using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp1;

namespace MyApp1Test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void Telに1が代入されたときエラーとなること()
        {
            var cut = new Employee();
            cut.Tel = "a";
        }
    }
}
