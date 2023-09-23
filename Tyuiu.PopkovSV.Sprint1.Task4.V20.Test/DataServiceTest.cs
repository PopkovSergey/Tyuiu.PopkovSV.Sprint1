﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint1.Task4.V20.Lib;

namespace Tyuiu.PopkovSV.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 7;
            double wait = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
