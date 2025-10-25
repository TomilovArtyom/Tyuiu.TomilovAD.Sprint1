using Tyuiu.TomilovAD.Sprint1.Task4.V1.Lib

namespace Tyuiu.TomilovAD.Sprint1.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -1;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}
