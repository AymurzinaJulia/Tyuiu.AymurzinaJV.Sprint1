using Tyuiu.AymurzinaJV.Sprint1.Task3.V7.Lib;
namespace Tyuiu.AymurzinaJV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 90;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(96012, res);
        }
    }
}
    