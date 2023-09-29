using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint1.Task6.V10.Lib;

namespace Tyuiu.PopkovSV.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Всем привет, меня зовут Сергей";
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter(strTest);
            string wait = "Всем привет, меня зоут Сергей";
            Assert.AreEqual(wait, res);

        }
    }
}
