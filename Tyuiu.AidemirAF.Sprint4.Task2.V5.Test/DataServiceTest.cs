using Tyuiu.AidemirAF.Sprint4.Task2.V5.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServcie ds = new DataServcie();
            int[] array = { 1, 2, 3, 4 };
            int res = ds.Calculate(array);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}