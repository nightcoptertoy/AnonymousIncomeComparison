using AnonymousIncomeApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Tests
{
    [TestFixture]
    class AnonymousIncome
    {
        [Test]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("5\n10\n15\n20"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    Program.Main();

                    var result = sw.ToString().Trim();
                    var arr = result.Split('\n', '\r').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    Assert.IsTrue(arr[0].Trim() == "Anonymous Income Comparison Program");
                    Assert.IsTrue(arr[1].Trim() == "Person 1");
                    Assert.IsTrue(arr[2].Trim() == "Hourly Rate?");
                    Assert.IsTrue(arr[3].Trim() == "Hours worked per week?");
                    Assert.IsTrue(arr[4].Trim() == "Person 2");
                    Assert.IsTrue(arr[5].Trim() == "Hourly Rate?");
                    Assert.IsTrue(arr[6].Trim() == "Hours worked per week?");
                    Assert.IsTrue(arr[7].Trim() == "Does Person 1 make more money than Person 2?");
                    Assert.IsTrue(arr[8].Trim() == "False");
                }
            }
        }
    }
}
