using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint1.Task7.V2.Lib;

namespace Tyuiu.PopkovSV.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 2.519;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
