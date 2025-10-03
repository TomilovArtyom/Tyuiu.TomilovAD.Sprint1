using Tyuiu.TomilovAD.Sprint1.Task1.V2.Lib;

namespace Tyuiu.TomilovAD.Sprint1.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 6.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
