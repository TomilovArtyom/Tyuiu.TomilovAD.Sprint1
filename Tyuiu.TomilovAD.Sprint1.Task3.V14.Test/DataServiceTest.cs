﻿using Tyuiu.TomilovAD.Sprint1.Task3.V14.Lib;

namespace Tyuiu.TomilovAD.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 123;
            var res = ds.ReverseNumber(x);
            Assert.AreEqual(321, res);
        }
    }
}
