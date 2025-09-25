using Tyuiu.AymurzinaJV.Sprint1.Task4.V5.Lib;

namespace Tyuiu.AymurzinaJV.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait,res);
        }
    }
}
