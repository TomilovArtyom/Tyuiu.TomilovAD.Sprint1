using Tyuiu.TomilovAD.Sprint1.Task7.V22.Lib;

namespace Tyuiu.TomilovAD.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 2;
            double y = 4;
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.172, res);
        }
    }
}
