using Tyuiu.AymurzinaJV.Sprint1.Task2.V29.Lib;

namespace Tyuiu.AymurzinaJV.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 61;
            var res = ds.ConvertSecondsToHours(x);
            Assert.AreEqual(1, res);
        }
    }
}
