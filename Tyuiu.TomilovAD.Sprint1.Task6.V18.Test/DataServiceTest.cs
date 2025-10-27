using Newtonsoft.Json.Linq;
using Tyuiu.TomilovAD.Sprint1.Task6.V18.Lib;

namespace Tyuiu.TomilovAD.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string StrTest = "один два два";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(StrTest);
            res = true;
        }
    }
}
