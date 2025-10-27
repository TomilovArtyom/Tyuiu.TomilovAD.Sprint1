using Tyuiu.TomilovAD.Sprint1.Task7.V22.Lib;

namespace Tyuiu.TomilovAD.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 90;
            double y = 90;
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1.831, res);
        }
    }
}
