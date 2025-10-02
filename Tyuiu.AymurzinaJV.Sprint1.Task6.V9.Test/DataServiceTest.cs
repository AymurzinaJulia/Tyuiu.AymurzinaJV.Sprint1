using Tyuiu.AymurzinaJV.Sprint1.Task6.V9.Lib;

namespace Tyuiu.AymurzinaJV.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string strTest = "123 456";
            string res = ds.MoveLetterToStart(strTest);
            string wait = "312 645";
            Assert.AreEqual(res, wait);
        }
    }
}
