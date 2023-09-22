using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint1.Task3.V15.Lib;

namespace Tyuiu.PopkovSV.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double V = 50;
            double L = 70;
            double S = 10;
            double T = 2;
            double wait = 250;
            var res = ds.DistanceOverTime(V, L, S, T);
            Assert.AreEqual(wait, res);
        }
    }
}
