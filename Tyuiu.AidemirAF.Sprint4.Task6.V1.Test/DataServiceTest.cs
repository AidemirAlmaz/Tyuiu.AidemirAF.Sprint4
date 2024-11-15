using Tyuiu.AidemirAF.Sprint4.Task6.V1.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var name = new string[] { "Алексей", "Валерия", "Егор" };
            int res = ds.Calculate(name);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}