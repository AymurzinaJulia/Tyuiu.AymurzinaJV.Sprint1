using Tyuiu.AymurzinaJV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.AymurzinaJV.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 90;
            double res = ds.FahrenheitToСelsius(x);

            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
