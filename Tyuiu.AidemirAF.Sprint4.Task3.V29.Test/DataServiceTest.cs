using Tyuiu.AidemirAF.Sprint4.Task3.V29.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[2, 2] 
            { { 1, 1},
              { 2, 2} };
            int res = ds.Calculate(mas2);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}