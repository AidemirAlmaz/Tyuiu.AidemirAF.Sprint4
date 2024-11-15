using Tyuiu.AidemirAF.Sprint4.Task1.V20.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 0, 1, 2, 3 };
            int res = ds.Calculate(array);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}