using Tyuiu.AymurzinaJV.Sprint1.Task7.V8.Lib;
namespace Tyuiu.AymurzinaJV.Sprint1.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
