using Tyuiu.AidemirAF.Sprint4.Task4.V11.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                { 1, 1},
                { 2, 2}
            };
            int res = ds.Calculate(matrix);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}